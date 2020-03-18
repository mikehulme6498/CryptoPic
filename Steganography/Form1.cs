using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        ImageInfo currentImage = new ImageInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image Files (*.png) | *.png;)",
                InitialDirectory = @"C:\Users\Mike\Desktop"
            };


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFile.FileName.ToString();
                pictureBox1.ImageLocation = txtFile.Text;
                currentImage.Image = new Bitmap(txtFile.Text);
                currentImage.Spacing = Convert.ToInt32(txtSpacing.Text);
                currentImage.SetInfo();
                lblHeight.Text = currentImage.Image.Height.ToString() + "px";
                lblWidth.Text = currentImage.Image.Width.ToString() + "px";
                lblMaxCharsInfo.Text = currentImage.AbsoluteMaxChars.ToString();
                btnStartAgain.Visible = true;
                btnOpenFile.Enabled = false;
                radDecode.Enabled = true;
                radEncode.Enabled = true;
            }

            
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (currentImage.IsMessageToBig(txtMessage.TextLength))
            {
                MessageBox.Show("Message is to big for this image.\nEither shorten the message or choose bigger image", "Message To Big", MessageBoxButtons.OK);
                return;
            }
            EncodeImage();
            
            SetRadButtonEnabled(false);
            ResetForm();
        }

        private void SetRadButtonEnabled(bool trueFalse)
        {
            radDecode.Enabled = trueFalse;
            radEncode.Enabled = trueFalse;
        }

        private void EncodeImage()
        {
            int currentPosInString = 0;
            int currentX = 10;
            int currentY = 10;
            Encode.EmbedMessageLength(currentImage, txtMessageToEncrypt.TextLength-1);
            Encode.EmbedSpacing(currentImage);
            Encode.EmbedEncodedFlags(currentImage);
            
            if (chkAdditionalWords.Checked)
            {
                Encode.EmbedAdditionalWordsFlag(currentImage);
            }

            do
            {
                Encode.ChangePixelsInRow(currentX, currentY, ref currentPosInString, currentImage, txtMessageToEncrypt.TextLength, txtMessageToEncrypt.Text);
                currentY += currentImage.Spacing;
            }
            while (currentPosInString < txtMessageToEncrypt.TextLength);


            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Image Files (*.png) | *.png;",
                InitialDirectory = @"C:\Users\Mike\Desktop"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                lblSaving.Visible = true;
                txtFile.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = txtFile.Text;
               

                Task save = new Task(() => SaveFile(txtFile.Text));
                save.Start();
                save.Wait();
                lblSaving.Visible = false;
                MessageBox.Show("Image Encoded & Saved", "Success");
            }
            else
            {
                ResetForm();
                currentImage.Reset();
            }

        }

        private void SaveFile(string path)
        {
            currentImage.Image.Save(path);
        }
        private void DecodeImage()
        {
            int currentY = 10;
            int messagePosition = 0;
            int[] sequence = { 13, 37, 22, 3, 64, 88, 57 }; 
            bool extraWords = Decode.HasItGotAdditionalWords(currentImage);
            currentImage.Spacing = Decode.GetSpacing(currentImage);
            currentImage.SetInfo();
            currentImage.MessageLength = Decode.GetMessageLength(currentImage);
            lblHeading.Text = "The Decoded message is";
            
            if (txtDecodePass.TextLength == 7)
            {
                sequence = GetAsciiNums(txtDecodePass.Text);
            }

            do
            {
                currentImage.DecodedMessage += Decode.GetMessage(currentImage, currentY, ref messagePosition);
                currentY += currentImage.Spacing;
            }
            while (messagePosition < currentImage.MessageLength);
            Console.WriteLine(currentImage.DecodedMessage);



            if (extraWords)
            {
                string message = CypherMessage(currentImage.DecodedMessage, false, sequence);
                string[] words = message.Trim().Split();
                

                for (int i = 0; i < words.Length; i+=3)
                {

                    if (i == words.Length)
                    {
                        txtMessageToEncrypt.Text += words[i];
                    }
                    else
                    {
                        txtMessageToEncrypt.Text += words[i] + " ";
                    }
                   
                }
            }
            else
            {
                
                txtMessageToEncrypt.Text = CypherMessage(currentImage.DecodedMessage, false, sequence);
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TxtMessage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateLabels();
                currentImage.Spacing = currentImage.CalculateBestSpacing(Convert.ToInt32(lblCharsUsed.Text));


                if (currentImage.IsMessageToBig(txtMessage.TextLength))
                {
                    txtMessage.ForeColor = Color.Red;
                    lblMessageToBig.Visible = true;
                }
                else
                {
                    txtMessage.ForeColor = Color.Black;
                    lblMessageToBig.Visible = false;
                }

            }
            catch
            {

            }
            finally
            {
                btnNextForOptions.Enabled = txtMessage.TextLength >= 1 ? true : false;
            }
        }

        private void UpdateLabels()
        {
            lblMaxChars.Text = currentImage.MaxCharactors.ToString();
            lblCharsUsed.Text = txtMessage.TextLength.ToString();
            txtSpacing.Text = currentImage.CalculateBestSpacing(Convert.ToInt32(lblCharsUsed.Text)).ToString();
            //txtMessageToEncrypt.Text = CypherMessage(txtMessage.Text, true);
        }

        private string CypherMessage(string message, bool trueForUp, int[] sequence)
        {
            List<string> messageList = ConvertStringToList(message);
            string cypheredMessage = "";
            int loopCounter = 1;

            for (int i = 0; i < messageList.Count; i++)
            {
                //int[] sequence = { 13, 37, 22, 3, 64, 88, 57 };
                char[] current = messageList[i].ToCharArray();

                for (int j = 0; j < current.Length; j++)
                {
                    switch (loopCounter)
                    {
                        case 1:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[0], trueForUp));
                            loopCounter++;
                            break;

                        case 2:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[1], trueForUp));
                            loopCounter++;
                            break;

                        case 3:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[2], trueForUp));
                            loopCounter++;
                            break;
                        case 4:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[3], trueForUp));
                            loopCounter++;
                            break;
                        case 5:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[4], trueForUp));
                            loopCounter++;
                            break;
                        case 6:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[5], trueForUp));
                            loopCounter++;
                            break;
                        case 7:
                            current[j] = Convert.ToChar(ShiftChars(Convert.ToInt32(current[j]), sequence[6], trueForUp));
                            loopCounter = 1;
                            break;
                    }
                }

                string tempWord = new string(current);
                cypheredMessage += tempWord + " ";
            }

            return cypheredMessage;
        }

        public List<string> ConvertStringToList(string message)
        {
            char[] seperator = { ' ' };
            string[] temp = message.Split(seperator);
            List<string> messageList = new List<string>();
            
            for (int i = 0; i < temp.Length; i++)
            {
                messageList.Add(temp[i]);
            }

            return messageList; 
        }

        private int ShiftChars(int charactor, int shiftBy, bool trueForUp)
        {
            int newNum;

            if (trueForUp)
            {
                if (charactor + shiftBy > 126)
                {
                    newNum = (charactor + shiftBy) - 126 + 33;

                    if(newNum > 126)
                    {
                        newNum = ShiftChars(33, newNum - 126, trueForUp);
                    }
                }
                else
                {
                    newNum = charactor + shiftBy;
                }
            }
            else
            {
                if (charactor - shiftBy < 33)
                {
                    newNum = (charactor - shiftBy) + 126 - 33;

                    if (newNum < 33)
                    {
                        newNum = ShiftChars(126, 33 - newNum, trueForUp);
                    }
                }
                else
                {
                    newNum = charactor - shiftBy;
                }
            }

            return newNum;
        }
     

        private void Button1_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
        }

        private void ChkAdditionalWords_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdditionalWords.Checked)
            {
                if (!currentImage.MessageSet)
                {
                    currentImage.SetOriginalMessage(txtMessage.Text);
                }
                currentImage.AddAdditionalWords();
                txtMessage.Text = currentImage.GetMessageAsString(currentImage.StringWithExtras);
            }
            else
            {
               
                txtMessage.Text = currentImage.GetMessageAsString(currentImage.OriginalString);
            }
        }


        private void TxtFile_TextChanged(object sender, EventArgs e)
        {
            if (txtFile.TextLength > 4)
            {
                pnlMessage.Visible = true;
                gbxImageDetails.Visible = true;
            }
        }

        private void TxtSpacing_TextChanged(object sender, EventArgs e)
        {
            if (txtSpacing.TextLength == 0 || txtSpacing.Text == "0")
            {
                currentImage.Spacing = 25;
            }
            else
            {
                currentImage.Spacing = Convert.ToInt32(txtSpacing.Text);
            }
            try
            {
                currentImage.SetInfo();
                UpdateLabels();
            }
            catch
            {
                // Try catch put in to prevent crash when the form resets as the setinfo 
                // is called when the text changes in message box. Crashes due to image now being null
            }
        }

        private void CheckRadioButtons()
        {
            if (radEncode.Checked)
            {
                pnlEnterMessage.Visible = true;
                lblHeading.Text = "Message That Will Be Encrypted Into Image";
                
            }
            else
            {
                pnlEnterMessage.Visible = false;
                lblHeading.Text = "The Decoded Message Is";
            }
        }
        private void RadEncode_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
            pnlEncryption.Visible = false;
            pnlDecodePassword.Visible = false;
        }

        private void RadDecode_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButtons();
            pnlDecodePassword.Visible = true;
        }

        private void BtnStartAgain_Click(object sender, EventArgs e)
        {
            btnStartAgain.Visible = false;
            SetRadButtonEnabled(true);
            currentImage.Reset();
            ResetForm();
            btnOpenFile.Enabled = true;
            pnlEnterMessage.Enabled = true;
        }

        private void ResetForm()
        {
            currentImage.Reset();
            chkPassword.Checked = false;
            pictureBox1.ImageLocation = "";
            txtFile.Text = "";
            txtSpacing.Text = "25";
            txtPassword.Text = "";
            chkAdditionalWords.Checked = false;
            txtMessage.Text = "";
            txtMessageToEncrypt.Text = "";
            pnlMessage.Visible = false;
            gbxImageDetails.Visible = false;
            pnlEnterMessage.Visible = false;
            radDecode.Checked = false;
            radEncode.Checked = false;
            pnlEncryption.Visible = false;
            pnlDecodePassword.Visible = false;
            txtDecodePass.Text = "";
            pnlOptions.Visible = false;
            btnOpenFile.Enabled = true;
            
            btnEncode.Enabled = false;
            btnStartAgain.Visible = false;
            txtMessageToEncrypt.Enabled = false;

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.Enabled = true;
                btnEncode.Enabled = false;
                btnNextFinalMessage.Enabled = false;
                lblPasswordRule.Visible = true;
            }
            else
            {
                txtPassword.Text = "";
                txtPassword.Enabled = false;
                btnNextFinalMessage.Enabled = true;
                lblPasswordRule.Visible = false;
            }
        }

        private void BtnShowHide(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnNextFinalMessage.Enabled = txtPassword.TextLength == 7 ? true : false;

            
        }

        private void BtnNextForOptions_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = true;
            btnNextFinalMessage.Enabled = true;
            pnlEnterMessage.Enabled = false;
        }

        private void BtnNextFinalMessage_Click(object sender, EventArgs e)
        {
            int[] sequence = { 13, 37, 22, 3, 64, 88, 57 };

            if (chkPassword.Checked && txtPassword.TextLength < 7)
            {
                MessageBox.Show("You have selected to use a password and it must be exactly 7 charactors, Please Adjust", "Password Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (chkPassword.Checked)
                {
                    sequence = GetAsciiNums(txtPassword.Text);
                }

                pnlEncryption.Visible = true;
                btnEncode.Enabled = true;
                txtMessageToEncrypt.Text = CypherMessage(txtMessage.Text, true, sequence);

            }
        }

        private int[] GetAsciiNums(string text)
        {
            char[] letters = text.ToCharArray();
            int[] sequence = new int[7];

            for (int i = 0; i<text.Length; i++)
            {
               sequence[i] = Convert.ToChar(letters[i]);
            }

            return sequence;
        }

        private void BtnShowHideDecode_Click(object sender, EventArgs e)
        {
            txtDecodePass.PasswordChar = txtDecodePass.PasswordChar == '*' ? '\0' : '*';
        }

        private void BtnNextDecode_Click(object sender, EventArgs e)
        {
            if (Decode.IsImageEncoded(currentImage))
            {
                pnlEncryption.Visible = true;
                SetRadButtonEnabled(false);
                DecodeImage();
                btnOpenFile.Enabled = false;
                txtMessageToEncrypt.Enabled = true;
                pnlDecodePassword.Visible = false;
            }
            else
            {
                MessageBox.Show("It appears no message has been embedded into this image.\n(Or maybe it has and it wasn't done using this software).\n\nPlease Try Another Image", "No Hidden Message", MessageBoxButtons.OK);
                ResetForm();
                currentImage.Reset();
                btnOpenFile.Enabled = true;
            }
            pnlEncryption.Visible = true;
        }

        private void PicShowHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '*' ? '\0' : '*';
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            txtDecodePass.PasswordChar = txtDecodePass.PasswordChar == '*' ? '\0' : '*';
        }

        private void ModifyTimeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FrmModifyDateTime();
            form.Show();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
