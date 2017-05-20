using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Chat_Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                RegisterNewUser();

                Close();
                Dispose();
            }
        }

        /// <summary>
        ///     Потрібно зробити захищений доступ до БД
        ///     Асинхронність +
        /// </summary>
        private void RegisterNewUser()
        {
            SqlConnection connection = null;
            SqlTransaction tx = null;
            try
            {
                connection =
                    new SqlConnection(
                        @"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                connection.Open();

                var insertIntoUsersCommand = "INSERT INTO Users (Login, Password) VALUES (@Username, @Pass);";

                var commandInsertUser = new SqlCommand(insertIntoUsersCommand, connection);

                commandInsertUser.Parameters.AddWithValue("Username", userNameTextBox.Text);
                commandInsertUser.Parameters.AddWithValue("Pass", passwordTextBox.Text);

                tx = connection.BeginTransaction();

                commandInsertUser.Transaction = tx;
                commandInsertUser.ExecuteNonQuery();

                var selectIDFromUsersCmd = "SELECT * FROM Users WHERE Login = @Username;";
                commandInsertUser.CommandText = selectIDFromUsersCmd;

                var id = (int) commandInsertUser.ExecuteScalar();

                if (!InsertNewUserInfo(id, tx, connection))
                    throw new Exception();

                MessageBox.Show(@"You have successfully signed up!" + Environment.NewLine +
                                @"Welcome to <CHAT> HERO <\CHAT>");

                tx.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tx?.Rollback();
                connection?.Close();
            }
        }

        private bool InsertNewUserInfo(int id, SqlTransaction tx, SqlConnection sc)
        {
            var result = false;

            try
            {
                var insertIntoUserInfoCommand =
                    "INSERT INTO UserInfo (FirstName, SecondName, Email, Country, Age, UserID) VALUES"
                    + "(@firstName, @lastName, @email, @country, @age, @userID);";

                var command = new SqlCommand(insertIntoUserInfoCommand, sc);

                command.Parameters.AddWithValue("firstName", firstNameTextBox.Text);
                command.Parameters.AddWithValue("lastName", lastNameTextBox.Text);
                command.Parameters.AddWithValue("email", emailTextBox.Text);
                command.Parameters.AddWithValue("country", countryTextBox.Text);
                command.Parameters.AddWithValue("age", ageTextBox.Text);
                command.Parameters.AddWithValue("userID", id);

                command.Transaction = tx;

                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private bool CheckAllFields()
        {
            var methodResult = false;

            if (userNameTextBox.Text == "" || userNameTextBox.Text.Length > 16)
            {
                MessageBox.Show(@"Please, input username!(16 Symbols max)");
            }
            else if (passwordTextBox.Text == "" || passwordTextBox.Text.Length > 16)
            {
                MessageBox.Show(@"Please, input password!(16 Symbols max)");
            }
            else if (firstNameTextBox.Text == "" || firstNameTextBox.Text.Length > 25)
            {
                MessageBox.Show(@"Please, input first name!(25 Symbols max)");
            }
            else if (lastNameTextBox.Text == "" || lastNameTextBox.Text.Length > 25)
            {
                MessageBox.Show(@"Please, input second name!(25 Symbols max)");
            }
            else if (emailTextBox.Text == "" || emailTextBox.Text.Length > 32)
            {
                MessageBox.Show(@"Please, input email!(32 Symbols max)");
            }
            else if (countryTextBox.Text == "" || countryTextBox.Text.Length > 16)
            {
                MessageBox.Show(@"Please, input country!(16 Symbols max)");
            }
            else if (ageTextBox.Text == "" || ageTextBox.Text.Length > 3 || !char.IsDigit(ageTextBox.Text, 0))
            {
                MessageBox.Show(@"Please, input age!");
            }
            else
            {
                methodResult = true;
            }

            return methodResult;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}