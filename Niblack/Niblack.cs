using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;


namespace Niblack 
{
    class NiblackAlgorithm 
    {
        //edit 11/16/20
       
        Bitmap verifiedImage;
        DirectBitmap gyorsitto;
        public Bitmap SetBitmap(Bitmap gyorsittto)
        {
            return gyorsittto;
        }
        static int ProgressValue;
        static public void SetBar(int x)
        {
            ProgressValue = x;
        }
        static public int GetBar()
        {
            return ProgressValue;
        }

        //edit 11/16/24 Helyettesiteni a Get Set pixel metodust 
        
            
        //edit 11/21/24

        static public Bitmap Binarization(Bitmap verifiedImage, float k, int Area)     
        {
            DirectBitmap gyorsitto = new DirectBitmap(verifiedImage.Width, verifiedImage.Height);

            var finalImage = new Bitmap(verifiedImage.Width, verifiedImage.Height, PixelFormat.Format32bppArgb);
            
            for (int i = 0; i < verifiedImage.Width; i++)   
            {
                for (int j = 0; j < verifiedImage.Height; j++)
                {
                    gyorsitto.SetPixel(i, j, NiblackColor(verifiedImage, i, j, k, Area));
                    //finalImage.SetPixel(i, j, NiblackColor(verifiedImage, i, j, k, Area));
                }
            }
            return gyorsitto.Bitmap;
        }
        private static Color NiblackColor(Bitmap verifiedImage, int x, int y, float k, int Area)  
        {
            

            int xLen = ((x + Area) > verifiedImage.Width ? verifiedImage.Width : x + Area);
            int yLen = ((y + Area) > verifiedImage.Height ? verifiedImage.Height : y + Area);

            List<Color> currentSet = new List<Color>();

            for (int i = ((x - Area) < 0 ? 0 : x - Area); i < xLen; i++)  
            {
                for (int j = ((y - Area) < 0 ? 0 : y - Area); j < yLen; j++)
                {
                    currentSet.Add(verifiedImage.GetPixel(i, j)); //helyettesiteni 
                    
                }
            }
            float rms = RMS(currentSet); ;
            float average = Average(currentSet);
            int niblackValue = (int)(average + (k * rms));
            return (verifiedImage.GetPixel(x, y).R > niblackValue ? Color.White : Color.Black);
        }
        private static float Average(List<Color> set)   
        {
            int average = 0;

            foreach (var color in set)
            {
                average += color.R;
            }
            return (average / set.Count);
        }

        private static float RMS(List<Color> set)
        {
            float average = Average(set);
            float rms = 0;
            foreach (var color in set)
            {
                rms += (float)Math.Pow(average - color.R, 2);
            }
            return (float)Math.Sqrt(rms / set.Count);
        }
    }
    
}

