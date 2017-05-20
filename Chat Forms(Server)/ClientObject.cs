using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms_Server_
{
    public struct ClientInfoStruct
    {
        public TcpClient User;
        public string Login;

    }
    public class ClientObject
    {
        #region Protected Properties

        protected internal string Id { get; private set; }

        protected internal NetworkStream Stream { get; private set; }

        #endregion

        #region Private Fieds

        private string _userName;
        private ClientInfoStruct _clientInfo;
        private readonly TcpClient _client;
        private readonly ServerObject _server;
        private readonly RichTextBox _chat;
        private readonly ComboBox _clientsComboBox;

        #endregion

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, RichTextBox chat, ComboBox clients)
        {
            _client = tcpClient;
            _server = serverObject;
            _clientsComboBox = clients;
            serverObject.AddConnection(this);
            this._chat = chat;
        }

        public void Process()
        {
            try
            {
                Stream = _client.GetStream();
                string message = GetMessage();
                _userName = message;

                message = _userName + " joined to chat!";

                _clientInfo.User = _client;
                _clientInfo.Login = _userName;
                _clientsComboBox.Items.Add(_clientInfo.Login);
                Id = GetID(_userName).ToString();

                _server.BroadcastMessage(message, this.Id);
                _chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");

                while (true)
                {
                    try
                    {
                        message = GetMessage();

                        if (message == "")
                        { throw new Exception(); }

                        message = String.Format("[ {0} ]: {1}", _userName, message);
                        _chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");
                        _server.BroadcastMessage(message, this.Id);
                    }
                    catch(Exception)
                    {
                        message = String.Format("[ {0} ]: покинул чат", _userName);
                        _chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");
                        _server.BroadcastMessage(message, this.Id);
                        
                        for(int i = 0; i < _clientsComboBox.Items.Count; ++i)
                        {
                            if(_clientsComboBox.Items[i].ToString() == _userName)
                            {
                                _clientsComboBox.Items.RemoveAt(i);
                            }
                        }

                        _clientsComboBox.Refresh();

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _server.DisconnectUser(this.Id);
                Close();
            }
        }

        private static int GetID(string username)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private string GetMessage()
        {
            StringBuilder builder = new StringBuilder();

            var data = new byte[64];

            do
            {
                var bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        protected internal void Close()
        {
            Stream?.Close();
            _client?.Close();
        }
    }
}
