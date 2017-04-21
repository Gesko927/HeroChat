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

        public ServerObject(RichTextBox chat)
        {
            this.chat = chat;
        }
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(string id)
        {
            ClientObject client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                clients.Remove(client);
            }
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

                    ClientObject clientObject = new ClientObject(tcpClient, this, chat);
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

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id != id) 
                {
                    clients[i].Stream.Write(data, 0, data.Length); 
                }
            }
        }

        protected internal void SendMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id == id)
                {
                    clients[i].Stream.Write(data, 0, data.Length);
                }
            }
        }

        protected internal void Disconnect()
        {
            tcpListener.Stop();

            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close(); 
            }
        }
    }
}
