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
            this.connectPictureBox = new System.Windows.Forms.PictureBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.sendPictureBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.connectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.chatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.userNameLabel.Location = new System.Drawing.Point(145, 20);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(156, 42);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Nickname";
            // 
            // chatTextBox
            // 
            this.chatTextBox.BackColor = System.Drawing.Color.White;
            this.chatTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTextBox.Location = new System.Drawing.Point(22, 194);
            this.chatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.Size = new System.Drawing.Size(327, 308);
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
            // connectPictureBox
            // 
            this.connectPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.connectPictureBox.Image = global::Chat_Forms.Properties.Resources._004_cloud_computing;
            this.connectPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("connectPictureBox.InitialImage")));
            this.connectPictureBox.Location = new System.Drawing.Point(281, 77);
            this.connectPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectPictureBox.Name = "connectPictureBox";
            this.connectPictureBox.Size = new System.Drawing.Size(65, 64);
            this.connectPictureBox.TabIndex = 7;
            this.connectPictureBox.TabStop = false;
            this.connectPictureBox.Click += new System.EventHandler(this.connectPictureBox_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.avatarPictureBox.Image = global::Chat_Forms.Properties.Resources._12;
            this.avatarPictureBox.Location = new System.Drawing.Point(9, 32);
            this.avatarPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(129, 154);
            this.avatarPictureBox.TabIndex = 8;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.avatarPictureBox_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(146, 65);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(130, 37);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Unknown";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Impact", 18F);
            this.countryLabel.Location = new System.Drawing.Point(146, 94);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(130, 37);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Unknown";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Impact", 18F);
            this.ageLabel.Location = new System.Drawing.Point(146, 123);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(130, 37);
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
            this.chatPanel.BackgroundImage = global::Chat_Forms.Properties.Resources.imgonline_com_ua_Resize_tD5X5MjUouHlg;
            this.chatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chatPanel.Controls.Add(this.sendPictureBox);
            this.chatPanel.Controls.Add(this.avatarPictureBox);
            this.chatPanel.Controls.Add(this.userNameLabel);
            this.chatPanel.Controls.Add(this.ageLabel);
            this.chatPanel.Controls.Add(this.chatTextBox);
            this.chatPanel.Controls.Add(this.countryLabel);
            this.chatPanel.Controls.Add(this.sendMsgTextBox);
            this.chatPanel.Controls.Add(this.nameLabel);
            this.chatPanel.Controls.Add(this.connectPictureBox);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(364, 661);
            this.chatPanel.TabIndex = 12;
            // 
            // sendPictureBox
            // 
            this.sendPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sendPictureBox.Image = global::Chat_Forms.Properties.Resources.sendButton;
            this.sendPictureBox.ImageActive = null;
            this.sendPictureBox.Location = new System.Drawing.Point(281, 509);
            this.sendPictureBox.Name = "sendPictureBox";
            this.sendPictureBox.Size = new System.Drawing.Size(68, 61);
            this.sendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendPictureBox.TabIndex = 12;
            this.sendPictureBox.TabStop = false;
            this.sendPictureBox.Zoom = 10;
            this.sendPictureBox.Click += new System.EventHandler(this.sendPictureBox_Click);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.connectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.PictureBox connectPictureBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuImageButton sendPictureBox;
    }
}

