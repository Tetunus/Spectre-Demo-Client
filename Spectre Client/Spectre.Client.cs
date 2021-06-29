/////////////////////////////////////////////////////////////////////
//                                                                 //
//  File: Spectre.Client.cs                                        //
//  Author: Tetunus (Josh)                                         //
//  Description: An example connection to the Spectre server       //
//               made in the C# programming language               //
//                                                                 //
/////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Security.Cryptography;

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

        public static string Encrypt(string data)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }
    }

    class Client
    {
        public static string IP = "";
        public static int Port = 8888; // Default value.
        public static bool IsEncrypted = false; // Default value.

        private static bool _is_connected = false;
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

                    _is_connected = true;

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
                _is_connected = false;

                _client.Close();
                _stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Spectre - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool IsConnected()
        {
            return _is_connected;
        }

        public static void Send(string message)
        {
            try
            {
                if (_is_connected)
                {
                    if (IsEncrypted)
                    {
                        message = Util.Encrypt(message);
                    }

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
                    if (IsEncrypted)
                    {
                        message = Util.Encrypt(message);
                    }

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
                    if (IsEncrypted)
                    {
                        message = Util.Encrypt(message);
                    }

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
