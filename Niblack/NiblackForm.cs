using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using System.Threading;

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
        // 11.21.2020
        
        //
        public float k = 0.1f;
        public int area  = 2;
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
                    
                    PB1.Size = VerifiedImage.Size;
                    PB1.Image = VerifiedImage;

                    PB1.Show();                                     
                    fLP1.AutoScroll = true;                        
                }
            }
        }
        
        private void codeBut_Click(object sender, EventArgs e)
        {
           


            PoB1.Value = NiblackAlgorithm.GetBar();



            try
            {
                if (kBox.Text == "" || areaBox.Text == "")
                    throw new Exception("Fields not filled!");

                float.TryParse(kBox.Text, out k);
                Int32.TryParse(areaBox.Text, out area);
                PoB1.Value = NiblackAlgorithm.GetBar();
                Bitmap afterNibleck = NiblackAlgorithm.Binarization(VerifiedImage, k, area);
                PB1.Image = afterNibleck;
                PB1.Show();
                afterNibleck.Save("AfterNiblack.png");
                Console.Out.WriteLine(NiblackAlgorithm.GetBar());
            PoB1.Value = NiblackAlgorithm.GetBar();
             }catch(Exception er)
            {
                //messagebox.show(er.tostring());
                MessageBox.Show(er.Message);
            }

           
            Console.Out.WriteLine(NiblackAlgorithm.GetBar());
            PoB1.Value = NiblackAlgorithm.GetBar();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PoB1_Click(object sender, EventArgs e)
        {

        }

        private void Niblack_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
