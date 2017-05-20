using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Chat_Forms.ClientClass;
using Chat_Forms.Properties;

namespace Chat_Forms
{
    public partial class ChatClientForm : Form
    {
        #region Private Fields

        private const string host = "127.0.0.1";
        private const int port = 8888;
        private readonly Client _chatClient;
        private readonly Image[] _avatars = new Image[17];
        private readonly Random _random;

        #endregion

        public ChatClientForm(string userName)
        {
            InitializeComponent();
            _chatClient = new Client(userName, chatTextBox);
            userNameLabel.Text = _chatClient.UserName;
            ShowUserInfo();
            _random = new Random();

            for (var i = 0; i < _avatars.Length; ++i)
                _avatars[i] = Image.FromFile(@"Charachters\" + (i + 1) + ".png");

            avatarPictureBox.Image = _avatars[_random.Next(0, 16)];
        }

        /// <summary>
        ///     Select information about client.
        /// </summary>
        private void ShowUserInfo()
        {
            using (var connection =
                new SqlConnection(
                    @"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True"))
            {
                connection.Open();

                var com = new SqlCommand(@"SELECT ID FROM Users WHERE Login = @Username;", connection);
                com.Parameters.AddWithValue("Username", _chatClient.UserName);
                var id = (int) com.ExecuteScalar();

                var command = new SqlCommand("SELECT FirstName, Country, Age FROM UserInfo WHERE UserID = @UserID;",
                    connection);
                command.Parameters.AddWithValue("UserID", id);
                var reader = command.ExecuteReader();
                reader.Read();

                nameLabel.Text = reader["FirstName"].ToString();
                countryLabel.Text = reader["Country"].ToString();
                ageLabel.Text = reader["Age"].ToString();
            }
        }

        #region Events

        private void connectPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                _chatClient.ConnectToServer(host, port);

                connectPictureBox.Image = Resources._005_cloud_computing_2;
                userNameLabel.ForeColor = Color.LimeGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connectPictureBox.Image = Resources._003_cloud_computing_1;
                userNameLabel.ForeColor = Color.DarkViolet;
                //chatClient.Disconnect();
            }
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            var filePath = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                avatarPictureBox.Image = Image.FromFile(filePath);
            }
            ;
        }

        private void sendPictureBox_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString() + "-----[ You ]: " + sendMsgTextBox.Text +
                                       "\n");
                _chatClient.SendMessage(sendMsgTextBox.Text);
                sendMsgTextBox.Text = "";
            }
        }

        private void ChatClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Close();
            _chatClient.Disconnect();
        }

        #endregion
    }
}