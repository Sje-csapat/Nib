﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Niblack
{
    class NiblackAlgorithm
    {
        static public Bitmap Binarization(Bitmap verifiedImage, float k, int Area)     
        {
            var finalImage = new Bitmap(verifiedImage.Width, verifiedImage.Height, PixelFormat.Format32bppArgb);
            for (int i = 0; i < verifiedImage.Width; i++)   
            {
                for (int j = 0; j < verifiedImage.Height; j++)
                {
                    finalImage.SetPixel(i, j, NiblackColor(verifiedImage, i, j, k, Area));  
                }
            }

            return finalImage;
        }


        private static Color NiblackColor(Bitmap im, int x, int y, float k, int Area)  
        {

            int xLen = ((x + Area) > im.Width ? im.Width : x + Area);
            int yLen = ((y + Area) > im.Height ? im.Height : y + Area);

            List<Color> currentSet = new List<Color>();

            for (int i = ((x - Area) < 0 ? 0 : x - Area); i < xLen; i++)  
            {
                for (int j = ((y - Area) < 0 ? 0 : y - Area); j < yLen; j++)
                {
                    currentSet.Add(im.GetPixel(i, j));                    
                }
            }


            float rms = RMS(currentSet); ;
            float average = Average(currentSet);
            int niblackValue = (int)(average + (k * rms));
            return (im.GetPixel(x, y).R > niblackValue ? Color.White : Color.Black);
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