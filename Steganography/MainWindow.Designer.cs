namespace Steganography
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxChars = new System.Windows.Forms.Label();
            this.lblCharsUsed = new System.Windows.Forms.Label();
            this.txtSpacing = new System.Windows.Forms.TextBox();
            this.chkAdditionalWords = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxImageDetails = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaxCharsInfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.pnlDecodePassword = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNextDecode = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDecodePass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblPasswordRule = new System.Windows.Forms.Label();
            this.picShowHide = new System.Windows.Forms.PictureBox();
            this.btnNextFinalMessage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEncryption = new System.Windows.Forms.Panel();
            this.txtMessageToEncrypt = new System.Windows.Forms.TextBox();
            this.pnlEnterMessage = new System.Windows.Forms.Panel();
            this.btnNextForOptions = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMessageToBig = new System.Windows.Forms.Label();
            this.gbxEncodeDecode = new System.Windows.Forms.GroupBox();
            this.radEncode = new System.Windows.Forms.RadioButton();
            this.radDecode = new System.Windows.Forms.RadioButton();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.lblSaving = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTimeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertFolderToPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxImageDetails.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.pnlDecodePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowHide)).BeginInit();
            this.pnlEncryption.SuspendLayout();
            this.pnlEnterMessage.SuspendLayout();
            this.gbxEncodeDecode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(25, 326);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(96, 25);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open PNG";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Enabled = false;
            this.btnEncode.Location = new System.Drawing.Point(965, 694);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(127, 326);
            this.txtFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(213, 22);
            this.txtFile.TabIndex = 4;
            this.txtFile.TextChanged += new System.EventHandler(this.TxtFile_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.Location = new System.Drawing.Point(19, 30);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.MaxLength = 100000;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(600, 138);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.TextChanged += new System.EventHandler(this.TxtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max Charactors :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Charactors Used :";
            // 
            // lblMaxChars
            // 
            this.lblMaxChars.AutoSize = true;
            this.lblMaxChars.Location = new System.Drawing.Point(147, 177);
            this.lblMaxChars.Name = "lblMaxChars";
            this.lblMaxChars.Size = new System.Drawing.Size(16, 17);
            this.lblMaxChars.TabIndex = 9;
            this.lblMaxChars.Text = "0";
            this.lblMaxChars.Visible = false;
            // 
            // lblCharsUsed
            // 
            this.lblCharsUsed.AutoSize = true;
            this.lblCharsUsed.Location = new System.Drawing.Point(147, 196);
            this.lblCharsUsed.Name = "lblCharsUsed";
            this.lblCharsUsed.Size = new System.Drawing.Size(16, 17);
            this.lblCharsUsed.TabIndex = 10;
            this.lblCharsUsed.Text = "0";
            // 
            // txtSpacing
            // 
            this.txtSpacing.Enabled = false;
            this.txtSpacing.Location = new System.Drawing.Point(123, 47);
            this.txtSpacing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpacing.Name = "txtSpacing";
            this.txtSpacing.Size = new System.Drawing.Size(33, 22);
            this.txtSpacing.TabIndex = 11;
            this.txtSpacing.Text = "25";
            this.txtSpacing.TextChanged += new System.EventHandler(this.TxtSpacing_TextChanged);
            // 
            // chkAdditionalWords
            // 
            this.chkAdditionalWords.AutoSize = true;
            this.chkAdditionalWords.Location = new System.Drawing.Point(291, 33);
            this.chkAdditionalWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAdditionalWords.Name = "chkAdditionalWords";
            this.chkAdditionalWords.Size = new System.Drawing.Size(332, 21);
            this.chkAdditionalWords.TabIndex = 13;
            this.chkAdditionalWords.Text = "Add Additional Random Words (Recommended)";
            this.chkAdditionalWords.UseVisualStyleBackColor = true;
            this.chkAdditionalWords.CheckedChanged += new System.EventHandler(this.ChkAdditionalWords_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Spacing :";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(15, 14);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(349, 19);
            this.lblHeading.TabIndex = 19;
            this.lblHeading.Text = "Message That Will Be Encrypted Into Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Height :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Width :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxImageDetails
            // 
            this.gbxImageDetails.BackColor = System.Drawing.SystemColors.Info;
            this.gbxImageDetails.Controls.Add(this.label8);
            this.gbxImageDetails.Controls.Add(this.lblMaxCharsInfo);
            this.gbxImageDetails.Controls.Add(this.label7);
            this.gbxImageDetails.Controls.Add(this.lblHeight);
            this.gbxImageDetails.Controls.Add(this.lblWidth);
            this.gbxImageDetails.Controls.Add(this.label6);
            this.gbxImageDetails.Controls.Add(this.label4);
            this.gbxImageDetails.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxImageDetails.Location = new System.Drawing.Point(25, 396);
            this.gbxImageDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxImageDetails.Name = "gbxImageDetails";
            this.gbxImageDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxImageDetails.Size = new System.Drawing.Size(315, 142);
            this.gbxImageDetails.TabIndex = 24;
            this.gbxImageDetails.TabStop = false;
            this.gbxImageDetails.Text = "Image Details";
            this.gbxImageDetails.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "(at a spacing of 10)";
            // 
            // lblMaxCharsInfo
            // 
            this.lblMaxCharsInfo.AutoSize = true;
            this.lblMaxCharsInfo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharsInfo.Location = new System.Drawing.Point(171, 94);
            this.lblMaxCharsInfo.Name = "lblMaxCharsInfo";
            this.lblMaxCharsInfo.Size = new System.Drawing.Size(18, 19);
            this.lblMaxCharsInfo.TabIndex = 27;
            this.lblMaxCharsInfo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Max Charactors : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(93, 62);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(34, 19);
            this.lblHeight.TabIndex = 25;
            this.lblHeight.Text = "0px";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(93, 33);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(34, 19);
            this.lblWidth.TabIndex = 24;
            this.lblWidth.Text = "0px";
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessage.Controls.Add(this.pnlDecodePassword);
            this.pnlMessage.Controls.Add(this.pnlOptions);
            this.pnlMessage.Controls.Add(this.label9);
            this.pnlMessage.Controls.Add(this.pnlEncryption);
            this.pnlMessage.Controls.Add(this.pnlEnterMessage);
            this.pnlMessage.Controls.Add(this.gbxEncodeDecode);
            this.pnlMessage.Location = new System.Drawing.Point(357, 43);
            this.pnlMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(686, 631);
            this.pnlMessage.TabIndex = 25;
            this.pnlMessage.Visible = false;
            // 
            // pnlDecodePassword
            // 
            this.pnlDecodePassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDecodePassword.Controls.Add(this.pictureBox2);
            this.pnlDecodePassword.Controls.Add(this.btnNextDecode);
            this.pnlDecodePassword.Controls.Add(this.label15);
            this.pnlDecodePassword.Controls.Add(this.label14);
            this.pnlDecodePassword.Controls.Add(this.txtDecodePass);
            this.pnlDecodePassword.Controls.Add(this.label13);
            this.pnlDecodePassword.Location = new System.Drawing.Point(27, 292);
            this.pnlDecodePassword.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDecodePassword.Name = "pnlDecodePassword";
            this.pnlDecodePassword.Size = new System.Drawing.Size(637, 123);
            this.pnlDecodePassword.TabIndex = 27;
            this.pnlDecodePassword.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Steganography.Properties.Resources.show_hide_icon_14;
            this.pictureBox2.Location = new System.Drawing.Point(393, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // btnNextDecode
            // 
            this.btnNextDecode.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNextDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDecode.Location = new System.Drawing.Point(567, 91);
            this.btnNextDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextDecode.Name = "btnNextDecode";
            this.btnNextDecode.Size = new System.Drawing.Size(49, 28);
            this.btnNextDecode.TabIndex = 28;
            this.btnNextDecode.Text = "Next";
            this.btnNextDecode.UseVisualStyleBackColor = false;
            this.btnNextDecode.Click += new System.EventHandler(this.BtnNextDecode_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(334, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Leave blank if no password was used for encryption";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Encryption Key :";
            // 
            // txtDecodePass
            // 
            this.txtDecodePass.Location = new System.Drawing.Point(276, 44);
            this.txtDecodePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecodePass.MaxLength = 7;
            this.txtDecodePass.Name = "txtDecodePass";
            this.txtDecodePass.PasswordChar = '*';
            this.txtDecodePass.Size = new System.Drawing.Size(109, 22);
            this.txtDecodePass.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "Encryption Key";
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlOptions.Controls.Add(this.lblPasswordRule);
            this.pnlOptions.Controls.Add(this.picShowHide);
            this.pnlOptions.Controls.Add(this.btnNextFinalMessage);
            this.pnlOptions.Controls.Add(this.label12);
            this.pnlOptions.Controls.Add(this.label5);
            this.pnlOptions.Controls.Add(this.chkPassword);
            this.pnlOptions.Controls.Add(this.chkAdditionalWords);
            this.pnlOptions.Controls.Add(this.txtSpacing);
            this.pnlOptions.Controls.Add(this.label11);
            this.pnlOptions.Controls.Add(this.txtPassword);
            this.pnlOptions.Location = new System.Drawing.Point(27, 290);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(637, 128);
            this.pnlOptions.TabIndex = 26;
            this.pnlOptions.Visible = false;
            // 
            // lblPasswordRule
            // 
            this.lblPasswordRule.AutoSize = true;
            this.lblPasswordRule.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRule.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPasswordRule.Location = new System.Drawing.Point(27, 106);
            this.lblPasswordRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordRule.Name = "lblPasswordRule";
            this.lblPasswordRule.Size = new System.Drawing.Size(253, 16);
            this.lblPasswordRule.TabIndex = 29;
            this.lblPasswordRule.Text = "Password must be exactly 7 charactors";
            this.lblPasswordRule.Visible = false;
            // 
            // picShowHide
            // 
            this.picShowHide.Image = global::Steganography.Properties.Resources.show_hide_icon_14;
            this.picShowHide.Location = new System.Drawing.Point(240, 78);
            this.picShowHide.Margin = new System.Windows.Forms.Padding(4);
            this.picShowHide.Name = "picShowHide";
            this.picShowHide.Size = new System.Drawing.Size(28, 25);
            this.picShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowHide.TabIndex = 28;
            this.picShowHide.TabStop = false;
            this.picShowHide.Click += new System.EventHandler(this.PicShowHide_Click);
            // 
            // btnNextFinalMessage
            // 
            this.btnNextFinalMessage.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNextFinalMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextFinalMessage.Enabled = false;
            this.btnNextFinalMessage.Location = new System.Drawing.Point(571, 96);
            this.btnNextFinalMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextFinalMessage.Name = "btnNextFinalMessage";
            this.btnNextFinalMessage.Size = new System.Drawing.Size(49, 28);
            this.btnNextFinalMessage.TabIndex = 25;
            this.btnNextFinalMessage.Text = "Next";
            this.btnNextFinalMessage.UseVisualStyleBackColor = false;
            this.btnNextFinalMessage.Click += new System.EventHandler(this.BtnNextFinalMessage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Options";
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(291, 59);
            this.chkPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(263, 21);
            this.chkPassword.TabIndex = 26;
            this.chkPassword.Text = "Use Encryption Key (Recommended)";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Encryption Key :";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(123, 78);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.MaxLength = 7;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(109, 22);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "What Would You like To Do?";
            // 
            // pnlEncryption
            // 
            this.pnlEncryption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEncryption.Controls.Add(this.txtMessageToEncrypt);
            this.pnlEncryption.Controls.Add(this.lblHeading);
            this.pnlEncryption.Location = new System.Drawing.Point(28, 442);
            this.pnlEncryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEncryption.Name = "pnlEncryption";
            this.pnlEncryption.Size = new System.Drawing.Size(631, 177);
            this.pnlEncryption.TabIndex = 25;
            this.pnlEncryption.Visible = false;
            // 
            // txtMessageToEncrypt
            // 
            this.txtMessageToEncrypt.Enabled = false;
            this.txtMessageToEncrypt.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageToEncrypt.Location = new System.Drawing.Point(15, 39);
            this.txtMessageToEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessageToEncrypt.Multiline = true;
            this.txtMessageToEncrypt.Name = "txtMessageToEncrypt";
            this.txtMessageToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageToEncrypt.Size = new System.Drawing.Size(601, 123);
            this.txtMessageToEncrypt.TabIndex = 20;
            // 
            // pnlEnterMessage
            // 
            this.pnlEnterMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEnterMessage.Controls.Add(this.btnNextForOptions);
            this.pnlEnterMessage.Controls.Add(this.label10);
            this.pnlEnterMessage.Controls.Add(this.lblMessageToBig);
            this.pnlEnterMessage.Controls.Add(this.button1);
            this.pnlEnterMessage.Controls.Add(this.lblCharsUsed);
            this.pnlEnterMessage.Controls.Add(this.lblMaxChars);
            this.pnlEnterMessage.Controls.Add(this.label3);
            this.pnlEnterMessage.Controls.Add(this.label2);
            this.pnlEnterMessage.Controls.Add(this.label1);
            this.pnlEnterMessage.Controls.Add(this.txtMessage);
            this.pnlEnterMessage.Location = new System.Drawing.Point(27, 36);
            this.pnlEnterMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEnterMessage.Name = "pnlEnterMessage";
            this.pnlEnterMessage.Size = new System.Drawing.Size(637, 235);
            this.pnlEnterMessage.TabIndex = 24;
            this.pnlEnterMessage.Visible = false;
            // 
            // btnNextForOptions
            // 
            this.btnNextForOptions.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNextForOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextForOptions.Enabled = false;
            this.btnNextForOptions.Location = new System.Drawing.Point(571, 203);
            this.btnNextForOptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextForOptions.Name = "btnNextForOptions";
            this.btnNextForOptions.Size = new System.Drawing.Size(49, 28);
            this.btnNextForOptions.TabIndex = 24;
            this.btnNextForOptions.Text = "Next";
            this.btnNextForOptions.UseVisualStyleBackColor = false;
            this.btnNextForOptions.Click += new System.EventHandler(this.BtnNextForOptions_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "(at current spacing - Will auto adjust)";
            this.label10.Visible = false;
            // 
            // lblMessageToBig
            // 
            this.lblMessageToBig.AutoSize = true;
            this.lblMessageToBig.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageToBig.ForeColor = System.Drawing.Color.Red;
            this.lblMessageToBig.Location = new System.Drawing.Point(165, 9);
            this.lblMessageToBig.Name = "lblMessageToBig";
            this.lblMessageToBig.Size = new System.Drawing.Size(388, 17);
            this.lblMessageToBig.TabIndex = 22;
            this.lblMessageToBig.Text = "Message is too big for image, please shorten message";
            this.lblMessageToBig.Visible = false;
            // 
            // gbxEncodeDecode
            // 
            this.gbxEncodeDecode.Controls.Add(this.radEncode);
            this.gbxEncodeDecode.Controls.Add(this.radDecode);
            this.gbxEncodeDecode.Location = new System.Drawing.Point(231, 4);
            this.gbxEncodeDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEncodeDecode.Name = "gbxEncodeDecode";
            this.gbxEncodeDecode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEncodeDecode.Size = new System.Drawing.Size(200, 27);
            this.gbxEncodeDecode.TabIndex = 22;
            this.gbxEncodeDecode.TabStop = false;
            // 
            // radEncode
            // 
            this.radEncode.AutoSize = true;
            this.radEncode.Location = new System.Drawing.Point(0, 5);
            this.radEncode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEncode.Name = "radEncode";
            this.radEncode.Size = new System.Drawing.Size(77, 21);
            this.radEncode.TabIndex = 0;
            this.radEncode.TabStop = true;
            this.radEncode.Text = "Encode";
            this.radEncode.UseVisualStyleBackColor = true;
            this.radEncode.CheckedChanged += new System.EventHandler(this.RadEncode_CheckedChanged);
            // 
            // radDecode
            // 
            this.radDecode.AutoSize = true;
            this.radDecode.Location = new System.Drawing.Point(81, 5);
            this.radDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radDecode.Name = "radDecode";
            this.radDecode.Size = new System.Drawing.Size(78, 21);
            this.radDecode.TabIndex = 1;
            this.radDecode.TabStop = true;
            this.radDecode.Text = "Decode";
            this.radDecode.UseVisualStyleBackColor = true;
            this.radDecode.CheckedChanged += new System.EventHandler(this.RadDecode_CheckedChanged);
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Location = new System.Drawing.Point(844, 694);
            this.btnStartAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(116, 23);
            this.btnStartAgain.TabIndex = 26;
            this.btnStartAgain.Text = "Start Again";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Visible = false;
            this.btnStartAgain.Click += new System.EventHandler(this.BtnStartAgain_Click);
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaving.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSaving.Location = new System.Drawing.Point(532, 694);
            this.lblSaving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(193, 22);
            this.lblSaving.TabIndex = 27;
            this.lblSaving.Text = "Saving Please Wait....";
            this.lblSaving.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 30);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyTimeDateToolStripMenuItem,
            this.convertFolderToPNGToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // modifyTimeDateToolStripMenuItem
            // 
            this.modifyTimeDateToolStripMenuItem.Name = "modifyTimeDateToolStripMenuItem";
            this.modifyTimeDateToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.modifyTimeDateToolStripMenuItem.Text = "Modify Time & Date";
            this.modifyTimeDateToolStripMenuItem.Click += new System.EventHandler(this.ModifyTimeDateToolStripMenuItem_Click);
            // 
            // convertFolderToPNGToolStripMenuItem
            // 
            this.convertFolderToPNGToolStripMenuItem.Name = "convertFolderToPNGToolStripMenuItem";
            this.convertFolderToPNGToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.convertFolderToPNGToolStripMenuItem.Text = "Convert Folder to *.PNG";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 752);
            this.Controls.Add(this.lblSaving);
            this.Controls.Add(this.btnStartAgain);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.gbxImageDetails);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrpytoPic - Image Encoder / Decoder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxImageDetails.ResumeLayout(false);
            this.gbxImageDetails.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlDecodePassword.ResumeLayout(false);
            this.pnlDecodePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowHide)).EndInit();
            this.pnlEncryption.ResumeLayout(false);
            this.pnlEncryption.PerformLayout();
            this.pnlEnterMessage.ResumeLayout(false);
            this.pnlEnterMessage.PerformLayout();
            this.gbxEncodeDecode.ResumeLayout(false);
            this.gbxEncodeDecode.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxChars;
        private System.Windows.Forms.Label lblCharsUsed;
        private System.Windows.Forms.TextBox txtSpacing;
        private System.Windows.Forms.CheckBox chkAdditionalWords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxImageDetails;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMaxCharsInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Panel pnlEnterMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxEncodeDecode;
        private System.Windows.Forms.RadioButton radDecode;
        private System.Windows.Forms.RadioButton radEncode;
        private System.Windows.Forms.Button btnStartAgain;
        private System.Windows.Forms.Panel pnlEncryption;
        private System.Windows.Forms.Label lblMessageToBig;
        private System.Windows.Forms.TextBox txtMessageToEncrypt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnNextFinalMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNextForOptions;
        private System.Windows.Forms.Panel pnlDecodePassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDecodePass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNextDecode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSaving;
        private System.Windows.Forms.PictureBox picShowHide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPasswordRule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTimeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertFolderToPNGToolStripMenuItem;
    }
}

