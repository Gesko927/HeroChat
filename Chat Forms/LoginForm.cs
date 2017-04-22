using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms
{
    public partial class LoginForm : Form
    {
        private ChatClientForm chatForm;
        private RegistrationForm registerForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private bool IsAllowedUser(string login, string password)
        {
            bool methodResult = false;
            int count = 0;

            SqlConnection connection;

            try
            {
                connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                connection.Open();
                string sqlCommand = "SELECT Count(*) FROM Users WHERE Login = '" + loginTextBox.Text + "' AND Password = '" + passwordTextBox.Text + "';";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if(count != 0)
            {
                methodResult = true;
            }

            return methodResult;
        }

        private void signInPictureBox_Click(object sender, EventArgs e)
        {
            if (IsAllowedUser(loginTextBox.Text, passwordTextBox.Text))
            {
                chatForm = new ChatClientForm(loginTextBox.Text);
                chatForm.Owner = this;

                chatForm.StartPosition = FormStartPosition.Manual;
                chatForm.Location = this.Location;

                chatForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password!");
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }

        private void signUpPictureBox_Click(object sender, EventArgs e)
        {
            registerForm = new RegistrationForm();
            registerForm.Owner = this;

            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = this.Location;

            registerForm.Show();
            this.Hide();
        }
    }
}
