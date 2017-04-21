using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Forms_Server_
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerObject server;
        RichTextBox chat;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, RichTextBox chat)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
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
                        
                        break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
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
                client.GetStream().Close();
                client.Close();
            }
        }
    }
}
