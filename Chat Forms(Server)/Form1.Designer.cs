using System.Windows.Forms;

namespace Chat_Forms_Server_
{
    partial class ChatServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatServerForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.disconnnectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectedStatePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeServerPictureBox = new System.Windows.Forms.PictureBox();
            this.startServerPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectedStatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startServerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 161);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTextBox.Location = new System.Drawing.Point(40, 36);
            this.chatTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.Size = new System.Drawing.Size(380, 395);
            this.chatTextBox.TabIndex = 2;
            this.chatTextBox.Text = "";
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMsgTextBox.Location = new System.Drawing.Point(429, 367);
            this.sendMsgTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(253, 50);
            this.sendMsgTextBox.TabIndex = 4;
            this.sendMsgTextBox.Text = "";
            // 
            // disconnnectBtn
            // 
            this.disconnnectBtn.Location = new System.Drawing.Point(481, 194);
            this.disconnnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnnectBtn.Name = "disconnnectBtn";
            this.disconnnectBtn.Size = new System.Drawing.Size(252, 49);
            this.disconnnectBtn.TabIndex = 5;
            this.disconnnectBtn.Text = "Disconnect";
            this.disconnnectBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectedStatePictureBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeServerPictureBox);
            this.panel1.Controls.Add(this.startServerPictureBox);
            this.panel1.Controls.Add(this.disconnnectBtn);
            this.panel1.Controls.Add(this.sendMsgTextBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.chatTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 444);
            this.panel1.TabIndex = 6;
            // 
            // connectedStatePictureBox
            // 
            this.connectedStatePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("connectedStatePictureBox.Image")));
            this.connectedStatePictureBox.Location = new System.Drawing.Point(573, 54);
            this.connectedStatePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectedStatePictureBox.Name = "connectedStatePictureBox";
            this.connectedStatePictureBox.Size = new System.Drawing.Size(70, 66);
            this.connectedStatePictureBox.TabIndex = 7;
            this.connectedStatePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 362);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 69);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeServerPictureBox
            // 
            this.closeServerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closeServerPictureBox.Image")));
            this.closeServerPictureBox.Location = new System.Drawing.Point(680, 54);
            this.closeServerPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeServerPictureBox.Name = "closeServerPictureBox";
            this.closeServerPictureBox.Size = new System.Drawing.Size(65, 66);
            this.closeServerPictureBox.TabIndex = 7;
            this.closeServerPictureBox.TabStop = false;
            this.closeServerPictureBox.Click += new System.EventHandler(this.closeServerPictureBox_Click);
            // 
            // startServerPictureBox
            // 
            this.startServerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("startServerPictureBox.Image")));
            this.startServerPictureBox.Location = new System.Drawing.Point(461, 54);
            this.startServerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.startServerPictureBox.Name = "startServerPictureBox";
            this.startServerPictureBox.Size = new System.Drawing.Size(66, 66);
            this.startServerPictureBox.TabIndex = 6;
            this.startServerPictureBox.TabStop = false;
            this.startServerPictureBox.Click += new System.EventHandler(this.startServerPictureBox_Click_1);
            // 
            // ChatServerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 444);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChatServerForm";
            this.Text = "Chat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatServerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectedStatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startServerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.Button disconnnectBtn;
        private System.Windows.Forms.Panel panel1;
        private PictureBox startServerPictureBox;
        private PictureBox closeServerPictureBox;
        private PictureBox pictureBox1;
        private PictureBox connectedStatePictureBox;

        public RichTextBox ChatTextBox
        {
            set
            {
                chatTextBox = value;
            }
        }
    }
}

