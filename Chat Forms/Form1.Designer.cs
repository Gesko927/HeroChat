namespace Chat_Forms
{
    partial class ChatClientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClientForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.sendPictureBox = new System.Windows.Forms.PictureBox();
            this.connectPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(146, 30);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 16;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(212, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your nickname:";
            // 
            // chatTextBox
            // 
            this.chatTextBox.BackColor = System.Drawing.Color.White;
            this.chatTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTextBox.Location = new System.Drawing.Point(22, 209);
            this.chatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.Size = new System.Drawing.Size(327, 293);
            this.chatTextBox.TabIndex = 3;
            this.chatTextBox.Text = "";
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMsgTextBox.Location = new System.Drawing.Point(22, 519);
            this.sendMsgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(255, 42);
            this.sendMsgTextBox.TabIndex = 4;
            this.sendMsgTextBox.Text = "";
            // 
            // sendPictureBox
            // 
            this.sendPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sendPictureBox.Enabled = false;
            this.sendPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sendPictureBox.Image")));
            this.sendPictureBox.Location = new System.Drawing.Point(285, 510);
            this.sendPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendPictureBox.Name = "sendPictureBox";
            this.sendPictureBox.Size = new System.Drawing.Size(66, 66);
            this.sendPictureBox.TabIndex = 6;
            this.sendPictureBox.TabStop = false;
            this.sendPictureBox.Click += new System.EventHandler(this.sendPictureBox_Click);
            // 
            // connectPictureBox
            // 
            this.connectPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.connectPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("connectPictureBox.Image")));
            this.connectPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("connectPictureBox.InitialImage")));
            this.connectPictureBox.Location = new System.Drawing.Point(257, 95);
            this.connectPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectPictureBox.Name = "connectPictureBox";
            this.connectPictureBox.Size = new System.Drawing.Size(71, 64);
            this.connectPictureBox.TabIndex = 7;
            this.connectPictureBox.TabStop = false;
            this.connectPictureBox.Click += new System.EventHandler(this.connectPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 127);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(146, 83);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 20);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Unknown";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(146, 117);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 20);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Unknown";
            this.countryLabel.Click += new System.EventHandler(this.countryLabel_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(146, 150);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(61, 20);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Unknown";
            this.ageLabel.Click += new System.EventHandler(this.ageLabel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(114, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.Color.White;
            this.chatPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chatPanel.BackgroundImage")));
            this.chatPanel.Controls.Add(this.pictureBox1);
            this.chatPanel.Controls.Add(this.label1);
            this.chatPanel.Controls.Add(this.ageLabel);
            this.chatPanel.Controls.Add(this.nameTextBox);
            this.chatPanel.Controls.Add(this.chatTextBox);
            this.chatPanel.Controls.Add(this.countryLabel);
            this.chatPanel.Controls.Add(this.sendMsgTextBox);
            this.chatPanel.Controls.Add(this.nameLabel);
            this.chatPanel.Controls.Add(this.sendPictureBox);
            this.chatPanel.Controls.Add(this.connectPictureBox);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(364, 661);
            this.chatPanel.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-policeman.png");
            this.imageList1.Images.SetKeyName(1, "002-plumber.png");
            this.imageList1.Images.SetKeyName(2, "003-boy.png");
            this.imageList1.Images.SetKeyName(3, "004-psycho.png");
            this.imageList1.Images.SetKeyName(4, "005-warrior.png");
            this.imageList1.Images.SetKeyName(5, "006-villian.png");
            this.imageList1.Images.SetKeyName(6, "007-superheroe-7.png");
            this.imageList1.Images.SetKeyName(7, "008-chicken.png");
            this.imageList1.Images.SetKeyName(8, "009-superheroe-6.png");
            this.imageList1.Images.SetKeyName(9, "010-superheroe-5.png");
            this.imageList1.Images.SetKeyName(10, "011-superheroe-4.png");
            this.imageList1.Images.SetKeyName(11, "012-superheroe-3.png");
            this.imageList1.Images.SetKeyName(12, "013-superheroe-2.png");
            this.imageList1.Images.SetKeyName(13, "014-robot.png");
            this.imageList1.Images.SetKeyName(14, "015-superheroe-8.png");
            this.imageList1.Images.SetKeyName(15, "016-superheroe-1.png");
            this.imageList1.Images.SetKeyName(16, "017-superheroe.png");
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "Pictures";
            // 
            // ChatClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 661);
            this.Controls.Add(this.chatPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatClientForm";
            this.Text = "Chat Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatClientForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.PictureBox sendPictureBox;
        private System.Windows.Forms.PictureBox connectPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

