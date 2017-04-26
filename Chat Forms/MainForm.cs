using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat_Forms
{
    public partial class ChatClientForm : Form
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        private Thread receiveThread;
        private Image[] avatars = new Image[17];
        private Random random;
        private bool connected;

        public ChatClientForm(string username)
        {
            InitializeComponent();
            connected = false;
            userName = username;
            userNameLabel.Text = username;
            ShowUserInfo();
            random = new Random();

            for(int i = 0; i < avatars.Length; ++i)
            {
                avatars[i] = Image.FromFile(@"Charachters\" + (i + 1).ToString() + ".png");
            }

            avatarPictureBox.Image = avatars[random.Next(0, 16)];
            
        }

        private void SendMessage(string msg)
        {
                string message = msg;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
        }

        private void ReceiveMessage()
        {
            while (client.Connected)
            {
                try
                {
                    string message = GetMessage();

                    if (message == "")
                    {
                        throw new Exception();
                    }

                    chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");
                }
                catch(Exception)
                {
                    chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----Connection failed!\n");

                    connectPictureBox.Image = Image.FromFile("003-cloud-computing-1.png");
                    userNameLabel.ForeColor = Color.DarkViolet;
                    connected = false;
                    break;
                }
            }
        }
        private string GetMessage()
        {
            byte[] data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return builder.ToString();
        }

        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
        }

        /// <summary>
        /// Відредагувати стрічку команди
        /// Зробити захист від дурня
        /// </summary>
        private void ShowUserInfo()
        {
            SqlConnection connection;

            try
            {
                connection = new SqlConnection(@"Data Source=DESKTOP-GECKO\SQLEXPRESS;Initial Catalog=ChatClientDB;Integrated Security=True");
                connection.Open();

                SqlCommand com = new SqlCommand(@"SELECT ID FROM Users WHERE Login = '" + userName + "';", connection);
                int id = (int)com.ExecuteScalar();

                SqlCommand command = new SqlCommand("SELECT FirstName, Country, Age FROM UserInfo WHERE UserID = " + id.ToString() + ";", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                nameLabel.Text = reader["FirstName"].ToString();
                countryLabel.Text = reader["Country"].ToString();
                ageLabel.Text = reader["Age"].ToString();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChatClientForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Disconnect();
        }


        private void connectPictureBox_Click(object sender, EventArgs e)
        {
            client = new TcpClient();

            if (connected)
            {
                MessageBox.Show("You are connected to this server already!");
            }
            else
            {
                try
                {
                    client.Connect(host, port);
                    stream = client.GetStream();

                    string message = userName;
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    sendPictureBox.Enabled = true;

                    receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                    receiveThread.Start();
                    connectPictureBox.Image = Image.FromFile("005-cloud-computing-2.png");
                    userNameLabel.ForeColor = Color.LimeGreen;
                    connected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Server is not responding. Try to connect later.");
                    Disconnect();
                }
            }
        }

        private void ChatClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
            Disconnect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                avatarPictureBox.Image = Image.FromFile(filePath);
            };
            
        }

        private void sendPictureBox_Click(object sender, EventArgs e)
        {
            if (sendMsgTextBox.Text != "")
            {
                chatTextBox.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----[ You ]: " + sendMsgTextBox.Text + "\n");
                SendMessage(sendMsgTextBox.Text);
                sendMsgTextBox.Text = "";
            }
        }
    }
}
