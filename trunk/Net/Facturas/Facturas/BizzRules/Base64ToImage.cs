﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;

namespace Facturas.BizzRules
{
    public class Base64ToImage
    {
        public static Bitmap ConvertThis(string ImageText)
        {
            Bitmap bitImage = null;

            if (ImageText.Length > 0)
            {
                //Byte[] bitmapData = new Byte[ImageText.Length];
                //bitmapData = Convert.FromBase64String(FixBase64ForImage(ImageText));

                System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream();

                

                bitImage = new Bitmap(50,50);


                Graphics g = Graphics.FromImage(bitImage);


                g.DrawString("My\nText", new Font("Tahoma", 8), Brushes.Red, new PointF(0, 0));
            }

            return bitImage;
        }
        public static string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);

            sbText.Replace("\r\n", String.Empty);

            sbText.Replace(" ", String.Empty);

            return sbText.ToString();
        }

    }//class

}
