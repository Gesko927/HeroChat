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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClientForm));
            this.userNameLabel = new System.Windows.Forms.Label();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.userNameLabel.Location = new System.Drawing.Point(145, 21);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(126, 34);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Nickname";
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
            this.connectPictureBox.Location = new System.Drawing.Point(286, 88);
            this.connectPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectPictureBox.Name = "connectPictureBox";
            this.connectPictureBox.Size = new System.Drawing.Size(65, 64);
            this.connectPictureBox.TabIndex = 7;
            this.connectPictureBox.TabStop = false;
            this.connectPictureBox.Click += new System.EventHandler(this.connectPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 128);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(146, 68);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(103, 29);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Unknown";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Impact", 18F);
            this.countryLabel.Location = new System.Drawing.Point(146, 110);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(103, 29);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Unknown";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Impact", 18F);
            this.ageLabel.Location = new System.Drawing.Point(146, 154);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(103, 29);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Unknown";
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
            this.chatPanel.Controls.Add(this.userNameLabel);
            this.chatPanel.Controls.Add(this.ageLabel);
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
        private System.Windows.Forms.Label userNameLabel;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

