using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Chat_Forms
{
    public partial class LoginForm : Form
    {
        #region Private Fields

        private ChatClientForm _chatForm;
        private RegisterForm _registerForm;

        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool IsAllowedUser()
        {
            var methodResult = false;
            var count = 0;

            using (var connection =
                new SqlConnection(
                    @"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True"))
            {
                connection.Open();

                const string sqlCommand = "SELECT Count(*) FROM Users WHERE Login = @Login AND Password = @Password ;";
                var command = new SqlCommand(sqlCommand, connection);
                command.Parameters.AddWithValue("@Login", loginTextBox.text);
                command.Parameters.AddWithValue("@Password", passwordTextBox.text);

                count = (int) command.ExecuteScalar();
                connection.Close();
            }

            if (count != 0)
                methodResult = true;


            return methodResult;
        }

        #region Events

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (IsAllowedUser())
            {
                _chatForm = new ChatClientForm(loginTextBox.text);
                _chatForm.Owner = this;

                _chatForm.StartPosition = FormStartPosition.Manual;
                _chatForm.Location = Location;

                _chatForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(@"Invalid login or password!");
                loginTextBox.text = "";
                passwordTextBox.text = "";
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            _registerForm = new RegisterForm();
            _registerForm.Owner = this;

            _registerForm.StartPosition = FormStartPosition.Manual;
            _registerForm.Location = Location;

            _registerForm.Show();
            Hide();
        }

        #endregion
    }
}