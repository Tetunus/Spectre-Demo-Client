using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Spectre
{
    class Util
    {
        public static string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1"; // should never happen.
        }
    }

    class Client
    {
        public static string IP = "";
        public static int Port = 8888;
        public static bool IsConnected = false;

        private static TcpClient _client;
        private static NetworkStream _stream;

        public static bool Connect()
        {
            try
            {
                if (IP != string.Empty && Port > 255 && Port < 65536) // min = 255 & max = 65535
                {
                    _client = new TcpClient(IP, Port);
                    _stream = _client.GetStream();

                    IsConnected = true;

                    return true;
                }
                else
                {
                    MessageBox.Show("Sorry, you did not specify the Spectre server address or used a incorrect port number, please define it and try again.", "Spectre - No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Sorry, we could not connect you to the Spectre server, make sure it is running and try again.", "Spectre - No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Spectre - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static void Disconnect()
        {
            try
            {
                IP = "";
                Port = 8888;
                IsConnected = false;

                _client.Close();
                _stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Spectre - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Send(string message)
        {
            try
            {
                if (IsConnected)
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    _stream.Write(data, 0, data.Length);
                }
            }
            catch (ObjectDisposedException)
            {
                // this is caused if the TcpClient and MemoryStream
                // objects are disposed and need to be reinstated.

                if (Connect())
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    _stream.Write(data, 0, data.Length);
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.ToString(), "Spectre - SocketException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                // this is caused if the server is restarted.
                // we need to reconnect THEN send the message.

                if (Connect())
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);

                    _stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Spectre - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
