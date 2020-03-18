using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    static class Decode
    {
        public static int GetSpacing(ImageInfo currentImage)
        {
            Color pixel = currentImage.Image.GetPixel(10, currentImage.Image.Height-10);
            int spacing = pixel.B;
            return spacing;
        }

        public static bool HasItGotAdditionalWords(ImageInfo currentImage)
        {
            Color pixel = currentImage.Image.GetPixel(20, currentImage.Image.Height - 10);
            int value = pixel.B;
            if (value == 69)
            {
                return true;
            }
            return false;
        }

        public static bool IsImageEncoded(ImageInfo currentImage)
        {
            int flag1, flag2;
            Color pixel;

            pixel = currentImage.Image.GetPixel(27, currentImage.Image.Height - 18);
            flag1 = pixel.B;
            pixel = currentImage.Image.GetPixel(currentImage.Image.Width - 23, currentImage.Image.Height - 14);
            flag2 = pixel.B;

            if (flag1 == 6 && flag2 == 7)
            {
                return true;
            }

            return false;
        }

        public static int GetMessageLength(ImageInfo currentImage)
        {
            int x = currentImage.Image.Width - 5;
            int y = currentImage.Image.Height - 5;
            Color pixel = currentImage.Image.GetPixel(x, y);
            int numberOfDigits = pixel.B;
            string messageLength = "";
            
            for (int i=0; i<numberOfDigits; i++)
            {
                x -= 10;
                pixel = currentImage.Image.GetPixel(x, y);
                char c = Convert.ToChar(pixel.B);
                string letter = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                messageLength += letter;
            }
            Console.WriteLine(numberOfDigits);
            Console.WriteLine(messageLength);

            return Convert.ToInt32(messageLength);
        }

        public static string GetMessage(ImageInfo currentImage, int currentY, ref int position)
        {
            Color pixel;
            int currentX = 10;
            int originalY = currentY;
            
            bool secondRow = false;
            string temp="";

            for (int x = currentX; x < (currentImage.HowManyCharsFitInWidth * currentImage.Spacing); x += currentImage.Spacing)
            {
                if (position == currentImage.MessageLength)
                {
                    break;
                }

                if (!secondRow)
                {
                    secondRow = true;
                    currentY = originalY;
                }
                else
                {
                    secondRow = false;
                    currentY = originalY + currentImage.Spacing;
                }

                pixel = currentImage.Image.GetPixel(x, currentY);
                char c = Convert.ToChar(pixel.B);
                string letter = Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                position++;
                temp += letter;
            }
            
            return temp; 
        }
    }
}
