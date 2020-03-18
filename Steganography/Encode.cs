using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    static class Encode

    {
        public static void EmbedAdditionalWordsFlag(ImageInfo currentImage)
        {
            Color pixel;
            pixel = currentImage.Image.GetPixel(20, currentImage.Image.Height - 10);
            currentImage.Image.SetPixel(20, currentImage.Image.Height - 10, Color.FromArgb(pixel.R, pixel.G, 69));
        }

        public static void EmbedEncodedFlags(ImageInfo currentImage)
        {
            Color pixel;
            pixel = currentImage.Image.GetPixel(27, currentImage.Image.Height - 18);
            currentImage.Image.SetPixel(27, currentImage.Image.Height - 18, Color.FromArgb(pixel.R, pixel.G, 6));

            pixel = currentImage.Image.GetPixel(currentImage.Image.Width - 23, currentImage.Image.Height - 14);
            currentImage.Image.SetPixel(currentImage.Image.Width - 23, currentImage.Image.Height - 14, Color.FromArgb(pixel.R, pixel.G, 7));
        }

        public static void EmbedSpacing(ImageInfo currentImage)
        {
            Color pixel;
            pixel = currentImage.Image.GetPixel(10, currentImage.Image.Height - 10);
            currentImage.Image.SetPixel(10, currentImage.Image.Height - 10, Color.FromArgb(pixel.R, pixel.G, currentImage.Spacing));

        }

        public static void EmbedMessageLength(ImageInfo currentImage, int messageLength)
        {
            List<int> length = new List<int>();
            string number = messageLength.ToString();
            Color pixel;

            int startX = currentImage.Image.Width - 5;
            int startY = currentImage.Image.Height - 5;

            foreach (char c in number)
            {
                length.Add(Convert.ToInt32(c));
            }

            pixel = currentImage.Image.GetPixel(startX, startY);
            currentImage.Image.SetPixel(startX, startY, Color.FromArgb(pixel.R, pixel.G, length.Count));
            startX -= 10;

            for (int i = 0; i < length.Count; i++)
            {
                currentImage.Image.SetPixel(startX, startY, Color.FromArgb(pixel.R, pixel.G, length[i]));
                startX -= 10;
            }


        }

        public static void ChangePixelsInRow(int currentX, int currentY, ref int currentPosInString, ImageInfo currentImage, int messageLength, string message)
        {
            Color pixel;
            int originalY = currentY;
            bool secondRow = false;

            for (int x = currentX; x < (currentImage.HowManyCharsFitInWidth * currentImage.Spacing); x += currentImage.Spacing)
            {
                if (currentPosInString == messageLength)
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

                char letter = Convert.ToChar(message.Substring(currentPosInString, 1));
                int value = Convert.ToInt32(letter);
                currentPosInString++;
                currentImage.Image.SetPixel(x, currentY, Color.FromArgb(pixel.R, pixel.G, value));
            }
        }
    }
}
