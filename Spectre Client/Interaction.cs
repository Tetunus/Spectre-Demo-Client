﻿/////////////////////////////////////////////////////////////////////
//                                                                 //
//  File: Interaction.cs                                           //
//  Author: Tetunus (Josh)                                         //
//  Description: An example connection to the Spectre server       //
//               made in the C# programming language               //
//                                                                 //
/////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;

using Spectre;

namespace Spectre_Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            serverIPTextBox.Text = Util.GetLocalIP();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messageTextBox.Text != string.Empty && serverIPTextBox.Text != string.Empty && portNumberTextBox.Text != string.Empty)
            {
                if (!Client.IsConnected)
                {
                    Client.IP = serverIPTextBox.Text;
                    Client.Port = Convert.ToInt32(portNumberTextBox.Text);

                    if (Client.Connect())
                    {
                        connectionLabel.Text = "Connected";
                        dataSizeLabel.Text = "Data Length Sent:" + messageTextBox.Text.Length.ToString();

                        Client.Send(messageTextBox.Text);
                    }
                }
                else
                {
                    dataSizeLabel.Text = "Data Length Sent:" + messageTextBox.Text.Length.ToString();

                    Client.Send(messageTextBox.Text);
                }
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (Client.IsConnected)
            {
                connectionLabel.Text = "Not Connected";

                Client.Disconnect();
            }
        }
    }
}
