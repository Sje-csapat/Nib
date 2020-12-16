using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace Niblack
{
    public partial class Niblack_Form : Form 
    {
        public Niblack_Form()
        {
            InitializeComponent();
            areaBox.Text = area.ToString();
            kBox.Text = k.ToString();
        }

        public Thread t;
        public Thread d;
        public Thread c;
       
        public float k = 0.1f;
        public int area = 2;
        private Bitmap VerifiedImage;

        private void OpenBut_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Csak képfájlok: (*.bmp, *.jpeg, *.png)|*.bmp;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    VerifiedImage = new Bitmap(openFileDialog.FileName);
                    PoB1.Maximum = VerifiedImage.Width;
                    PoB1.Value = 0;
                    PB1.Size = VerifiedImage.Size;
                    PB1.Image = VerifiedImage;
                    PB1.Show();
                    fLP1.AutoScroll = true;
                    
                }
            }
        }

        private void codeBut_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(szamitas));
            d = new Thread(new ThreadStart(frissites));
            c = new Thread(new ThreadStart(reset));
            t.Start();
            d.Start();
        }
        ////////////////////////   2020.12.15 - Niblack algoritmus futatása T szálon
        public void szamitas()
        {
            c.Start();
            reset();
            Bitmap afterNibleck = NiblackAlgorithm.Binarization(VerifiedImage, k, area);
            pictureBox1.Invoke(new MethodInvoker(
        delegate ()
        {
            pictureBox1.Image = afterNibleck;
            try
            {
                if (kBox.Text == "" || areaBox.Text == "")
                    throw new Exception("Fields not filled!");
                    float.TryParse(kBox.Text, out k);
                    Int32.TryParse(areaBox.Text, out area);
                    PoB1.Value = NiblackAlgorithm.GetBar();
                    pictureBox1.Size = afterNibleck.Size;
                    pictureBox1.Image = afterNibleck;
                    pictureBox1.Show();
                    flowLayoutPanel1.AutoScroll = true;
                    afterNibleck.Save("AfterNiblack.png");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }));
        }
        ////////////////////////   2020.12.15 - Progress bar aktualis érték frissitése D szálon 
        public void frissites()
        {
            do
            {
                PoB1.Invoke(new MethodInvoker(
        delegate ()
        {

            PoB1.Value = NiblackAlgorithm.GetBar();
        }));
                Thread.Sleep(10);
            } while (PoB1.Value <PB1.Width-1);
            
        }
        public void reset()
        {
            PoB1.Invoke(new MethodInvoker(
        delegate ()
        {
            PoB1.Value = 0;
            PoB1.Maximum = PB1.Width;
        }));
        }
        
        ////////////////////////   2020.12.06 - Sobel Operator implementálás

        //Sobel x-tengely pixel csere kernel
        private static double[,] xSobel
        {
            get
            {
                return new double[,]
                {
                    { -1, 0, 1 },
                    { -2, 0, 2 },
                    { -1, 0, 1 }
                };
            }
        }

        //Sobel y-tengely pixel csere kernel
        private static double[,] ySobel
        {
            get
            {
                return new double[,]
                {
                    {  1,  2,  1 },
                    {  0,  0,  0 },
                    { -1, -2, -1 }
                };
            }
        }
        static public Bitmap ConvolutionFilter(Bitmap afterNibleck, double[,] xkernel, double[,] ykernel, double factor = 1, int bias = 0, bool grayscale = false)
        {

            //Kép méretek tárolása
            int width = afterNibleck.Width;
            int height = afterNibleck.Height;

            //Lock
            BitmapData srcData = afterNibleck.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            //Bite számítás - 32 bytes / pixel x kép szélesség x kép magasság ->  32bpp 
            int bytes = srcData.Stride * srcData.Height;

            //Mátrix létrehozása
            byte[] pixelBuffer = new byte[bytes];
            byte[] resultBuffer = new byte[bytes];

            //Első pixel cím szerzés
            IntPtr srcScan0 = srcData.Scan0;

            //Adattárolás 1 bitnyi adatba
            Marshal.Copy(srcScan0, pixelBuffer, 0, bytes);

            //Unlock
            afterNibleck.UnlockBits(srcData);

            //Szürkeárnyalat (ha szükséges)
            if (grayscale == true)
            {
                float rgb = 0;
                for (int i = 0; i < pixelBuffer.Length; i += 4)
                {
                    rgb = pixelBuffer[i] * .21f;
                    rgb += pixelBuffer[i + 1] * .71f;
                    rgb += pixelBuffer[i + 2] * .071f;
                    pixelBuffer[i] = (byte)rgb;
                    pixelBuffer[i + 1] = pixelBuffer[i];
                    pixelBuffer[i + 2] = pixelBuffer[i];
                    pixelBuffer[i + 3] = 255;
                }
            }

            //Változó létrehozása pixel adatoknak (kernel)
            double xr = 0.0;
            double xg = 0.0;
            double xb = 0.0;
            double yr = 0.0;
            double yg = 0.0;
            double yb = 0.0;
            double rt = 0.0;
            double gt = 0.0;
            double bt = 0.0;


            int filterOffset = 1;
            int calcOffset = 0;
            int byteOffset = 0;

            //Start with the pixel that is offset 1 from top and 1 from the left side
            //this is so entire kernel is on your image
            for (int OffsetY = filterOffset; OffsetY < height - filterOffset; OffsetY++)
            {
                for (int OffsetX = filterOffset; OffsetX < width - filterOffset; OffsetX++)
                {
                    //reset rgb values to 0
                    xr = xg = xb = yr = yg = yb = 0;
                    rt = gt = bt = 0.0;

                    //position of the kernel center pixel
                    byteOffset = OffsetY * srcData.Stride + OffsetX * 4;

                    //kernel calculations
                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + filterX * 4 + filterY * srcData.Stride;
                            xb += (double)(pixelBuffer[calcOffset]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            xg += (double)(pixelBuffer[calcOffset + 1]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            xr += (double)(pixelBuffer[calcOffset + 2]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            yb += (double)(pixelBuffer[calcOffset]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                            yg += (double)(pixelBuffer[calcOffset + 1]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                            yr += (double)(pixelBuffer[calcOffset + 2]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    //total rgb values for this pixel
                    bt = Math.Sqrt((xb * xb) + (yb * yb));
                    gt = Math.Sqrt((xg * xg) + (yg * yg));
                    rt = Math.Sqrt((xr * xr) + (yr * yr));

                    //set limits, bytes can hold values from 0 up to 255;
                    if (bt > 255) bt = 255;
                    else if (bt < 0) bt = 0;
                    if (gt > 255) gt = 255;
                    else if (gt < 0) gt = 0;
                    if (rt > 255) rt = 255;
                    else if (rt < 0) rt = 0;

                    //set new data in the other byte array for your image data
                    resultBuffer[byteOffset] = (byte)(bt);
                    resultBuffer[byteOffset + 1] = (byte)(gt);
                    resultBuffer[byteOffset + 2] = (byte)(rt);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            //Create new bitmap which will hold the processed data
            Bitmap resultImage = new Bitmap(width, height);

            //Lock bits into system memory
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            //Copy from byte array that holds processed data to bitmap
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            //Unlock bits from system memory
            resultImage.UnlockBits(resultData);

            //Return processed image
            return resultImage;
        }

    
    private void button1_Click(object sender, EventArgs e)
        {
            Bitmap afterSobel = ConvolutionFilter(VerifiedImage, xSobel, ySobel, 1.0, 0, true);
            Invalidate();
            pictureBox3.Size = afterSobel.Size;
            pictureBox3.Image = afterSobel;
            pictureBox3.Show();
            flowLayoutPanel2.AutoScroll = true;
            afterSobel.Save("AfterSobel.png");
        }
    }
}
