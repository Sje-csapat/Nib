using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Niblack
{
    public partial class Niblack_Form : Form 
    {
        public int progresBarData;
        public int barReturn(int szam)
        {
            
            PoB1.Value = szam;
            return PoB1.Value;
        }

        public float k = -0.2f;
        public int area  = 4;
        private Bitmap VerifiedImage;
     
        public Niblack_Form()       
        {
            InitializeComponent();
            areaBox.Text = area.ToString();
            kBox.Text = k.ToString();
        }
        
        

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
           
           this.PoB1.Value=50;
            try
            {
                if (kBox.Text == "" || areaBox.Text == "")
                    throw new Exception("Fields not filled!");

                float.TryParse(kBox.Text, out k);
                Int32.TryParse(areaBox.Text, out area);


                Bitmap afterNibleck = NiblackAlgorithm.Binarization(VerifiedImage, k, area);
                PB1.Image = afterNibleck;
                PB1.Show();
                afterNibleck.Save("AfterNiblack.png");
            }
            catch (Exception er)
            {
                    MessageBox.Show(er.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PoB1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
