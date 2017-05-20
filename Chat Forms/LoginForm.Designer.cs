namespace Chat_Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signUpBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.signInBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.loginTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signUpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.BackgroundImage = global::Chat_Forms.Properties.Resources.ChatLogoWithHeros;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPanel.Controls.Add(this.signUpBtn);
            this.loginPanel.Controls.Add(this.signInBtn);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.loginPictureBox);
            this.loginPanel.Controls.Add(this.passwordPictureBox);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(356, 651);
            this.loginPanel.TabIndex = 0;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.Image = global::Chat_Forms.Properties.Resources.SignUp;
            this.signUpBtn.ImageActive = null;
            this.signUpBtn.Location = new System.Drawing.Point(193, 562);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(100, 59);
            this.signUpBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.TabStop = false;
            this.signUpBtn.Zoom = 5;
            this.signUpBtn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.Image = global::Chat_Forms.Properties.Resources.SignIn;
            this.signInBtn.ImageActive = null;
            this.signInBtn.Location = new System.Drawing.Point(63, 562);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(100, 59);
            this.signInBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signInBtn.TabIndex = 8;
            this.signInBtn.TabStop = false;
            this.signInBtn.Zoom = 5;
            this.signInBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.BackgroundImage")));
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.Icon")));
            this.passwordTextBox.Location = new System.Drawing.Point(88, 499);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(182, 36);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.text = "";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.loginTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTextBox.BackgroundImage")));
            this.loginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F);
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("loginTextBox.Icon")));
            this.loginTextBox.Location = new System.Drawing.Point(88, 373);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(182, 36);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.text = "";
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.Image = global::Chat_Forms.Properties.Resources.LoginBtn;
            this.loginPictureBox.Location = new System.Drawing.Point(63, 307);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(230, 127);
            this.loginPictureBox.TabIndex = 2;
            this.loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.Image = global::Chat_Forms.Properties.Resources.PasswordBtn;
            this.passwordPictureBox.Location = new System.Drawing.Point(63, 430);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(230, 126);
            this.passwordPictureBox.TabIndex = 1;
            this.passwordPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(356, 651);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signUpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private Bunifu.Framework.UI.BunifuTextbox passwordTextBox;
        private Bunifu.Framework.UI.BunifuTextbox loginTextBox;
        private Bunifu.Framework.UI.BunifuImageButton signInBtn;
        private Bunifu.Framework.UI.BunifuImageButton signUpBtn;
    }
}