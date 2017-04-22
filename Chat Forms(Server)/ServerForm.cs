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
    public partial class ChatServerForm : Form
    {
        static ServerObject server; 
        static Thread listenThread;    
        public ChatServerForm()
        {
            InitializeComponent();
        }

        private void ChatServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null)
            {
                server.Disconnect();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void closeServerPictureBox_Click(object sender, EventArgs e)
        {
            if(server != null)
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----Server is off.\n");
                connectedStatePictureBox.Image = Image.FromFile("002-wifi.png");

                server.Disconnect();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----[ Server ]: " + sendMsgTextBox.Text + "\n");
                server.BroadcastMessage("[ Server ]: " + sendMsgTextBox.Text, "none");
                sendMsgTextBox.Text = "";
            }
        }

        private void startServerPictureBox_Click_1(object sender, EventArgs e)
        {
            try
            {
                connectedStatePictureBox.Image = Image.FromFile("001-wifi-signal.png");
                server = new ServerObject(chatTextBox, clientComboBox);
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); 
            }
            catch (Exception)
            {
                server.Disconnect();
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            string info = GetUserInfo(clientComboBox.SelectedItem.ToString());
            MessageBox.Show(info);
            

        }

        private string GetUserInfo(string username)
        {
            string result = "None";

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM UserInfo Where UserID = (SELECT ID FROM Users WHERE Login = '" + username + "');", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                result = string.Format("Login:\t {0}" + Environment.NewLine + "First Name:\t {1}" + Environment.NewLine +
                                              "Second Name:\t {2}" + Environment.NewLine + "Email:\t {3}" + Environment.NewLine +
                                              "Country:\t {4}" + Environment.NewLine + "Age:\t {5}", username, reader.GetString(1),
                                              reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private int GetID(string username)
        {
            int result = 0;

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT ID FROM Users WHERE Login = '" + username + "';", connection);
                connection.Open();
                result = (int)command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private void sendPrivateMsgBtn_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                string id = GetID(clientComboBox.SelectedItem.ToString()).ToString();
                server.SendMessage("[ Server PRIVATE ]: " + sendMsgTextBox.Text, id);
                sendMsgTextBox.Text = "";
            }
        }

        private void disconnnectBtn_Click(object sender, EventArgs e)
        {
            string username = clientComboBox.SelectedItem.ToString();

            server.DisconnectUser(GetID(username).ToString());

            for (int i = 0; i < clientComboBox.Items.Count; ++i)
            {
                if (clientComboBox.Items[i].ToString() == username)
                {
                    clientComboBox.Items.RemoveAt(i);
                }
            }

        }
    }
}
