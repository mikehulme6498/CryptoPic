using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class ImageInfo
    {
        // Encoding Properties

        public int HowManyCharsFitInWidth { get; private set; }
        public int RowsPossible { get; private set; }
        public int MaxCharactors { get; private set; }
        public int AbsoluteMaxChars { get; private set; }
        public int Spacing { get; set; }
        public int BestSpacing { get; set; }
        public Bitmap Image { get; set; }
        public bool MessageSet { get; private set; } = false;
        public List<string> StringWithExtras = new List<string>();
        public List<string> OriginalString = new List<string>();


        // Decoding Properties

        public int MessageLength { get; set; }
        public string DecodedMessage { get; set; }

        public ImageInfo()
        {
            
        }

        public void Reset()
        {
            HowManyCharsFitInWidth = 0;
            RowsPossible = 0;
            MaxCharactors = 0;
            AbsoluteMaxChars = 0;
            Spacing = 0;
            BestSpacing = 0;
            Image = null;
            MessageSet = false;
            StringWithExtras.Clear();
            OriginalString.Clear();
            MessageLength = 0;
            DecodedMessage = null;
        }

        public void SetInfo()
        {
            HowManyCharsFitInWidth = Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Width - 10) / Spacing)));
            RowsPossible = Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Height - 20) / Spacing)));
            MaxCharactors = HowManyCharsFitInWidth * RowsPossible;
            AbsoluteMaxChars = (Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Width - 10) / 10)))) * (Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Height - 20) / 10))));
        }

        public int CalculateBestSpacing(int charsUsed)
        {
            int spacing = 255;
            bool foundBest = false;

            do
            {
                int tempHowManyCharsFitInWidth = Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Width - 10) / spacing)));
                int tempRowsPossible = Convert.ToInt32(Math.Floor(Convert.ToDouble((Image.Height - 20) / spacing)));

                if (charsUsed > (tempHowManyCharsFitInWidth * tempRowsPossible))
                {
                    spacing--;
                }
                else
                {
                    foundBest = true;
                }
            } while (!foundBest);
            
            return spacing;
        }

        public void SetOriginalMessage(string message)
        {
            char[] seperator = { ' ' };
            string[] temp = message.Split(seperator);
            for(int i=0; i< temp.Length; i++)
            {
                OriginalString.Add(temp[i]);
            }
            MessageSet = true;
            //originalMessageEncrypted = OriginalString;
        }

        public void AddAdditionalWords()
        {
            List<string> temp = new List<string>();
            StringWithExtras = null;

            for (int i =0; i < OriginalString.Count; i++)
            {
                temp.Add(this.OriginalString[i]);
                temp.Add(RandomWords.GenerateRandomWord());
                temp.Add(RandomWords.GenerateRandomWord());
            }
            
            StringWithExtras = temp;
            
        }

        public string GetMessageAsString(List<string> message)
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (string word in message)
            {
                builder.Append(word + " ");
            }

            return builder.ToString();
        }

        public bool IsMessageToBig(int messageLength)
        {
            if (messageLength >= AbsoluteMaxChars)
            {
                return true;
            }

            return false;
        }
    }
}
