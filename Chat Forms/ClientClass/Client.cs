using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chat_Forms.ClientClass
{
    internal class Client
    {
        #region Private Fields

        private static TcpClient _client;
        private static NetworkStream _stream;
        private readonly RichTextBox _chatTextBox;
        private Thread _receiveThread;

        #endregion

        #region Public Fields

        public bool Connected { get; private set; }

        public string UserName { get; }

        #endregion

        public Client(string userName, RichTextBox box)
        {
            UserName = userName;
            Connected = false;
            _chatTextBox = box;
        }

        /// <summary>
        ///     Send message to a connected server.
        /// </summary>
        /// <param name="msg">Message which to be sent</param>
        public void SendMessage(string msg)
        {
            var message = msg;
            var data = Encoding.Unicode.GetBytes(message);
            _stream.Write(data, 0, data.Length);
        }

        /// <summary>
        ///     Method for receiving a message from server.
        /// </summary>
        /// <returns>Received message</returns>
        private string GetMessage()
        {
            var data = new byte[64];
            var builder = new StringBuilder();
            do
            {
                var bytes = _stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            } while (_stream.DataAvailable);

            return builder.ToString();
        }

        /// <summary>
        ///     Connect to server with IP-address and Port
        /// </summary>
        /// <param name="host">Server`s IP-address</param>
        /// <param name="port">Server`s port</param>
        public void ConnectToServer(string host, int port)
        {
            _client = new TcpClient();

            if (Connected)
            {
                //throw new Exception("Client already connected!");
            }
            else
            {
                try
                {
                    _client.Connect(host, port);
                    _stream = _client.GetStream();

                    var message = UserName;
                    var data = Encoding.Unicode.GetBytes(message);
                    _stream.Write(data, 0, data.Length);

                    _receiveThread = new Thread(ListenMessage);
                    _receiveThread.Start();
                    Connected = true;
                }
                catch (Exception)
                {
                    //connected = false;
                    throw new Exception("Server is not responding. Try to connect later.");
                }
            }
        }

        /// <summary>
        ///     Method for listening messages from server.
        /// </summary>
        private void ListenMessage()
        {
            try
            {
                while (_client.Connected)
                    try
                    {
                        var message = GetMessage();

                        if (message == "")
                            throw new Exception("Server timed out");

                        _chatTextBox.AppendText(DateTime.Now.ToShortTimeString() + "-----" + message + "\n");
                    }
                    catch (Exception)
                    {
                        Connected = false;
                        _chatTextBox.AppendText(DateTime.Now.ToShortTimeString() + "-----Connection failed!\n");
                        break;
                        //throw new Exception("Connection was failed!");                    
                    }
            }
            finally
            {
                throw new Exception();
            }
        }

        /// <summary>
        ///     Close client`s TCP connection and NetworkStream stream.
        /// </summary>
        public void Disconnect()
        {
            _stream?.Close();
            _client?.Close();
        }
    }
}