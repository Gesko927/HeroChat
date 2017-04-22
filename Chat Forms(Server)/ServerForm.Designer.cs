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
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.disconnnectBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendPrivateMsgBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.connectedStatePictureBox = new System.Windows.Forms.PictureBox();
            this.sendMsgPictureBox = new System.Windows.Forms.PictureBox();
            this.closeServerPictureBox = new System.Windows.Forms.PictureBox();
            this.startServerPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectedStatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendMsgPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startServerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(428, 145);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(133, 24);
            this.clientComboBox.TabIndex = 1;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatTextBox.Location = new System.Drawing.Point(40, 36);
            this.chatTextBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.sendMsgTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(253, 50);
            this.sendMsgTextBox.TabIndex = 4;
            this.sendMsgTextBox.Text = "";
            // 
            // disconnnectBtn
            // 
            this.disconnnectBtn.Location = new System.Drawing.Point(568, 191);
            this.disconnnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.disconnnectBtn.Name = "disconnnectBtn";
            this.disconnnectBtn.Size = new System.Drawing.Size(114, 49);
            this.disconnnectBtn.TabIndex = 5;
            this.disconnnectBtn.Text = "Disconnect";
            this.disconnnectBtn.UseVisualStyleBackColor = true;
            this.disconnnectBtn.Click += new System.EventHandler(this.disconnnectBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendPrivateMsgBtn);
            this.panel1.Controls.Add(this.infoBtn);
            this.panel1.Controls.Add(this.connectedStatePictureBox);
            this.panel1.Controls.Add(this.sendMsgPictureBox);
            this.panel1.Controls.Add(this.closeServerPictureBox);
            this.panel1.Controls.Add(this.startServerPictureBox);
            this.panel1.Controls.Add(this.disconnnectBtn);
            this.panel1.Controls.Add(this.sendMsgTextBox);
            this.panel1.Controls.Add(this.clientComboBox);
            this.panel1.Controls.Add(this.chatTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 444);
            this.panel1.TabIndex = 6;
            // 
            // sendPrivateMsgBtn
            // 
            this.sendPrivateMsgBtn.Location = new System.Drawing.Point(427, 191);
            this.sendPrivateMsgBtn.Name = "sendPrivateMsgBtn";
            this.sendPrivateMsgBtn.Size = new System.Drawing.Size(134, 49);
            this.sendPrivateMsgBtn.TabIndex = 10;
            this.sendPrivateMsgBtn.Text = "Send Private Message";
            this.sendPrivateMsgBtn.UseVisualStyleBackColor = true;
            this.sendPrivateMsgBtn.Click += new System.EventHandler(this.sendPrivateMsgBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(568, 145);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(114, 36);
            this.infoBtn.TabIndex = 9;
            this.infoBtn.Text = "INFO";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // connectedStatePictureBox
            // 
            this.connectedStatePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("connectedStatePictureBox.Image")));
            this.connectedStatePictureBox.Location = new System.Drawing.Point(522, 54);
            this.connectedStatePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectedStatePictureBox.Name = "connectedStatePictureBox";
            this.connectedStatePictureBox.Size = new System.Drawing.Size(70, 66);
            this.connectedStatePictureBox.TabIndex = 7;
            this.connectedStatePictureBox.TabStop = false;
            // 
            // sendMsgPictureBox
            // 
            this.sendMsgPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sendMsgPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sendMsgPictureBox.Image")));
            this.sendMsgPictureBox.Location = new System.Drawing.Point(690, 362);
            this.sendMsgPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendMsgPictureBox.Name = "sendMsgPictureBox";
            this.sendMsgPictureBox.Size = new System.Drawing.Size(65, 69);
            this.sendMsgPictureBox.TabIndex = 8;
            this.sendMsgPictureBox.TabStop = false;
            this.sendMsgPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeServerPictureBox
            // 
            this.closeServerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closeServerPictureBox.Image")));
            this.closeServerPictureBox.Location = new System.Drawing.Point(617, 54);
            this.closeServerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.closeServerPictureBox.Name = "closeServerPictureBox";
            this.closeServerPictureBox.Size = new System.Drawing.Size(65, 66);
            this.closeServerPictureBox.TabIndex = 7;
            this.closeServerPictureBox.TabStop = false;
            this.closeServerPictureBox.Click += new System.EventHandler(this.closeServerPictureBox_Click);
            // 
            // startServerPictureBox
            // 
            this.startServerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("startServerPictureBox.Image")));
            this.startServerPictureBox.Location = new System.Drawing.Point(429, 54);
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
            this.ClientSize = new System.Drawing.Size(766, 444);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatServerForm";
            this.Text = "Chat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatServerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectedStatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendMsgPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startServerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox clientComboBox;
        internal System.Windows.Forms.RichTextBox chatTextBox;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.Button disconnnectBtn;
        private System.Windows.Forms.Panel panel1;
        private PictureBox startServerPictureBox;
        private PictureBox closeServerPictureBox;
        private PictureBox sendMsgPictureBox;
        private PictureBox connectedStatePictureBox;
        private Button infoBtn;
        private Button sendPrivateMsgBtn;

        public RichTextBox ChatTextBox
        {
            set
            {
                chatTextBox = value;
            }
        }
    }
}

