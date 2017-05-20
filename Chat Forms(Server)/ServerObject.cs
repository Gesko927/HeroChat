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

        #region Public Fields

        public List<ClientObject> Clients = new List<ClientObject>();

        #endregion

        #region Private Fields

        private static TcpListener _tcpListener;
        private readonly RichTextBox _chat;
        private readonly ComboBox _clientComboBox;

        #endregion

        public ServerObject(RichTextBox chat, ComboBox clientComboBox)
        {
            this._clientComboBox = clientComboBox;
            this._chat = chat;
        }

        protected internal void AddConnection(ClientObject clientObject)
        {
            Clients.Add(clientObject);
        }

        protected internal void Listen()
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Any, 8888);
                _tcpListener.Start();
                _chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----Server is on.\n");

                while (true)
                {
                    TcpClient tcpClient = _tcpListener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(tcpClient, this, _chat, _clientComboBox);
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

            foreach (ClientObject cl in Clients)
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

            foreach (ClientObject cl in Clients)
            {
                if (cl.Id == id)
                {
                    cl.Stream.Write(data, 0, data.Length);
                }
            }
        }

        protected internal void Disconnect()
        {
            _tcpListener.Stop();

            foreach (ClientObject cl in Clients)
            {
                cl.Close();
            }

            Clients.Clear();
        }

        protected internal void DisconnectUser(string id)
        {
            ClientObject client = null;

            foreach (ClientObject cl in Clients)
            {
                if (cl.Id == id)
                {
                    client = cl;
                    cl.Close();
                }
            }

            Clients.Remove(client);
        }

        protected internal void RemoveClientFromComboBox(string username)
        {
            for (int i = 0; i < _clientComboBox.Items.Count; ++i)
            {
                if (_clientComboBox.Items[i].ToString() == username)
                {
                    _clientComboBox.Items.RemoveAt(i);
                }
            }
        }
    }
}
