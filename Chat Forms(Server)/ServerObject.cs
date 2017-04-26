using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms_Server_
{
    public class ServerObject
    {
        static TcpListener tcpListener;
        public List<ClientObject> clients = new List<ClientObject>();
        private RichTextBox chat;
        private ComboBox clientComboBox;

        public ServerObject(RichTextBox chat, ComboBox clientComboBox)
        {
            this.clientComboBox = clientComboBox;
            this.chat = chat;
        }

        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }

        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----Server is on.\n");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    ClientObject clientObject = new ClientObject(tcpClient, this, chat, clientComboBox);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception)
            {
                Disconnect();
            }
        }

        protected internal void BroadcastMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);

            foreach (ClientObject cl in clients)
            {
                if (cl != null && cl.Id != id)
                {
                    cl.Stream.Write(data, 0, data.Length);
                }
            }
        }

        protected internal void SendMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);

            foreach (ClientObject cl in clients)
            {
                if (cl.Id == id)
                {
                    cl.Stream.Write(data, 0, data.Length);
                }
            }
        }

        protected internal void Disconnect()
        {
            tcpListener.Stop();

            foreach (ClientObject cl in clients)
            {
                cl.Close();
            }

            clients.Clear();
        }

        protected internal void DisconnectUser(string id)
        {
            ClientObject client = null;

            foreach (ClientObject cl in clients)
            {
                if (cl.Id == id)
                {
                    client = cl;
                    cl.Close();
                }
            }

            clients.Remove(client);
        }

        protected internal void RemoveClientFromComboBox(string username)
        {
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
