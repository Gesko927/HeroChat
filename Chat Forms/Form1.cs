using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        Thread receiveThread;

        public ChatClientForm()
        {
            InitializeComponent();
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
                client.GetStream().Close();
                client.Close();
            }
        }

        private void ChatClientForm_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Disconnect();
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

        private void connectPictureBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                userName = nameTextBox.Text;
                client = new TcpClient();
                

                try
                {
                    client.Connect(host, port);
                    nameLabel.Text = userName;
                    stream = client.GetStream(); 

                    string message = userName;
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    sendPictureBox.Enabled = true;

                    
                    receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                    receiveThread.Start();
                    connectPictureBox.Image = Image.FromFile("005-cloud-computing-2.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("Server is not responding. Try to connect later.");
                    Disconnect();
                }
            }
            else
            {
                MessageBox.Show("Please, input your nickname!");
            }
        }

        private void countryLabel_Click(object sender, EventArgs e)
        {
            InputBox.InputBox input = new InputBox.InputBox("country");
            countryLabel.Text = input.getString();
        }

        private void ageLabel_Click(object sender, EventArgs e)
        {
            InputBox.InputBox input = new InputBox.InputBox("age");
            ageLabel.Text = input.getString();
        }

        private void ChatClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //openFileDialog1.
        }
    }
}
