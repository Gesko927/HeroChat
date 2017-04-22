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
        public TcpClient user;
        public string login;

    }
    public class ClientObject
    {
        protected internal string Id { get; private set; }

        protected internal NetworkStream Stream { get; private set; }

        string userName;

        ClientInfoStruct clientInfo;
        TcpClient client;
        ServerObject server;
        RichTextBox chat;
        ComboBox clientsComboBox;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, RichTextBox chat, ComboBox clients)
        {
            client = tcpClient;
            server = serverObject;
            clientsComboBox = clients;
            serverObject.AddConnection(this);
            this.chat = chat;
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                string message = GetMessage();
                userName = message;

                message = userName + " joined to chat!";

                clientInfo.user = client;
                clientInfo.login = userName;
                clientsComboBox.Items.Add(clientInfo.login);
                Id = GetID(userName).ToString();

                server.BroadcastMessage(message, this.Id);
                chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");

                while (true)
                {
                    try
                    {
                        message = GetMessage();

                        if (message == "")
                        { throw new Exception(); }

                        message = String.Format("[ {0} ]: {1}", userName, message);
                        chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");
                        server.BroadcastMessage(message, this.Id);
                    }
                    catch(Exception)
                    {
                        message = String.Format("[ {0} ]: покинул чат", userName);
                        chat.AppendText(DateTime.Now.ToShortTimeString().ToString() + "-----" + message + "\n");
                        server.BroadcastMessage(message, this.Id);
                        
                        for(int i = 0; i < clientsComboBox.Items.Count; ++i)
                        {
                            if(clientsComboBox.Items[i].ToString() == userName)
                            {
                                clientsComboBox.Items.RemoveAt(i);
                            }
                        }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                server.RemoveConnection(this.Id);
                Close();
            }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private string GetMessage()
        {
            StringBuilder builder = new StringBuilder();

            byte[] data = new byte[64];
            
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);
         
            return builder.ToString();
        }

        protected internal void Close()
        {
            if (Stream != null)
            {
                Stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
