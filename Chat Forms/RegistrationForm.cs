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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void signUpPictureBox_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                RegisterNewUser();

                this.Close();
                this.Dispose();
            }
        }

        private void RegisterNewUser()
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                connection.Open();

                string insertIntoUsersCommand = string.Format("INSERT INTO Users (Login, Password) VALUES ('{0}', '{1}');", userNameTextBox.Text, passwordTextBox.Text);
                SqlCommand commandInsert = new SqlCommand(insertIntoUsersCommand, connection);
                commandInsert.ExecuteNonQuery();

                string selectIDFromUsersCmd = string.Format("Select * From Users Where Login = '" + userNameTextBox.Text + "';");
                SqlCommand commandSelect = new SqlCommand(selectIDFromUsersCmd, connection);
                int id = (int)commandSelect.ExecuteScalar();

                string values = string.Format("'{0}','{1}','{2}','{3}','{4}', '{5}'", firstNameTextBox.Text, secondNameTextBox.Text, emailTextBox.Text, countryTextBox.Text, ageTextBox.Text, id);
                string insertIntoUserInfoCommand = string.Format("Insert into UserInfo (FirstName, SecondName, Email, Country, Age, UserID) values ({0});", values);
                commandInsert.CommandText = insertIntoUserInfoCommand;
                commandInsert.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("You have successfully signed up!" + Environment.NewLine + @"Welcome to HERO <\CHAT>");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckAllFields()
        {
            bool methodResult = false;

            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Please, input username!");
                methodResult = false;
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please, input password!");
                methodResult = false;
            }
            else if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Please, input first name!");
                methodResult = false;
            }
            else if (secondNameTextBox.Text == "")
            {
                MessageBox.Show("Please, input second name!");
                methodResult = false;
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please, input email!");
                methodResult = false;
            }
            else if (countryTextBox.Text == "")
            {
                MessageBox.Show("Please, input country!");
                methodResult = false;
            }
            else if (ageTextBox.Text == "")
            {
                MessageBox.Show("Please, input age!");
                methodResult = false;
            }
            else { methodResult = true; }

            return methodResult;
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
