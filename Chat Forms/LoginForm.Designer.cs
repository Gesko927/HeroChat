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
            this.signUpPictureBox = new System.Windows.Forms.PictureBox();
            this.signInPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signUpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPanel.Controls.Add(this.signUpPictureBox);
            this.loginPanel.Controls.Add(this.signInPictureBox);
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
            // signUpPictureBox
            // 
            this.signUpPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.signUpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("signUpPictureBox.Image")));
            this.signUpPictureBox.Location = new System.Drawing.Point(193, 562);
            this.signUpPictureBox.Name = "signUpPictureBox";
            this.signUpPictureBox.Size = new System.Drawing.Size(100, 50);
            this.signUpPictureBox.TabIndex = 6;
            this.signUpPictureBox.TabStop = false;
            this.signUpPictureBox.Click += new System.EventHandler(this.signUpPictureBox_Click);
            // 
            // signInPictureBox
            // 
            this.signInPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.signInPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("signInPictureBox.Image")));
            this.signInPictureBox.Location = new System.Drawing.Point(63, 562);
            this.signInPictureBox.Name = "signInPictureBox";
            this.signInPictureBox.Size = new System.Drawing.Size(100, 50);
            this.signInPictureBox.TabIndex = 6;
            this.signInPictureBox.TabStop = false;
            this.signInPictureBox.Click += new System.EventHandler(this.signInPictureBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(88, 500);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(182, 27);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(88, 375);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(182, 27);
            this.loginTextBox.TabIndex = 3;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.Image")));
            this.loginPictureBox.Location = new System.Drawing.Point(63, 307);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(230, 127);
            this.loginPictureBox.TabIndex = 2;
            this.loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordPictureBox.Image")));
            this.passwordPictureBox.Location = new System.Drawing.Point(63, 430);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(230, 126);
            this.passwordPictureBox.TabIndex = 1;
            this.passwordPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(356, 651);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signUpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox signUpPictureBox;
        private System.Windows.Forms.PictureBox signInPictureBox;
    }
}