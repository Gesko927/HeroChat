using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                server = new ServerObject(chatTextBox);
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); 
            }
            catch (Exception)
            {
                server.Disconnect();
            }
        }

        
    }
}
