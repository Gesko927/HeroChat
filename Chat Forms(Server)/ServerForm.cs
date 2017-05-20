using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms_Server_
{
    public partial class ChatServerForm : MetroFramework.Forms.MetroForm
    {
        private static ServerObject _server; 
        private static Thread _listenThread; 
           
        public ChatServerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private string GetUserInfo(string username)
        {
            string result = "None";


            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM UserInfo Where UserID = (SELECT ID FROM Users WHERE Login = @Login);", connection);
                command.Parameters.AddWithValue("Login", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                result = string.Format("Login:\t {0}" + Environment.NewLine + "First Name:\t {1}" + Environment.NewLine +
                                       "Second Name:\t {2}" + Environment.NewLine + "Email:\t {3}" + Environment.NewLine +
                                       "Country:\t {4}" + Environment.NewLine + "Age:\t {5}", username, reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFieldValue<int>(5));
            }


            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private int GetID(string username)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("SELECT ID FROM Users WHERE Login = @Login;", connection);
                command.Parameters.AddWithValue("Login", username);
                connection.Open();
                result = (int)command.ExecuteScalar();
            }

            return result;
        }

        #region Events

        private void ChatServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_server != null)
            {
                _server.Disconnect();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void closeServerPictureBox_Click(object sender, EventArgs e)
        {
            if(_server != null)
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----Server is off.\n");
                connectedStatePictureBox.Image = Image.FromFile("002-wifi.png");

                _server.Disconnect();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----[ Server ]: " + sendMsgTextBox.Text + "\n");
                _server.BroadcastMessage("[ Server ]: " + sendMsgTextBox.Text, "none");
                sendMsgTextBox.Text = "";
            }
        }

        private void startServerPictureBox_Click_1(object sender, EventArgs e)
        {
            try
            {
                connectedStatePictureBox.Image = Image.FromFile("001-wifi-signal.png");
                _server = new ServerObject(chatTextBox, clientComboBox);
                _listenThread = new Thread(new ThreadStart(_server.Listen));
                _listenThread.Start(); 
            }
            catch (Exception)
            {
                _server.Disconnect();
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            string info = GetUserInfo(clientComboBox.SelectedItem.ToString());
            MessageBox.Show(info);
        }

        private void sendPrivateMsgBtn_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                string id = GetID(clientComboBox.SelectedItem.ToString()).ToString();
                _server.SendMessage("[ Server PRIVATE ]: " + sendMsgTextBox.Text, id);
                sendMsgTextBox.Text = "";
            }
        }

        private void disconnnectBtn_Click(object sender, EventArgs e)
        {
            string username = clientComboBox.SelectedItem.ToString();

            _server.DisconnectUser(GetID(username).ToString());

            _server.RemoveClientFromComboBox(username);

            clientComboBox.Refresh();
        }

        #endregion
    }
}
