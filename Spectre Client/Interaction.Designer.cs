
namespace Spectre_Client
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.serverIPTextBox = new System.Windows.Forms.TextBox();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.portNumberTextBox = new System.Windows.Forms.TextBox();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.dataSizeLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(12, 373);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(163, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 161);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(334, 183);
            this.messageTextBox.TabIndex = 2;
            this.messageTextBox.Text = "";
            // 
            // serverIPTextBox
            // 
            this.serverIPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverIPTextBox.Location = new System.Drawing.Point(66, 107);
            this.serverIPTextBox.Name = "serverIPTextBox";
            this.serverIPTextBox.Size = new System.Drawing.Size(280, 20);
            this.serverIPTextBox.TabIndex = 3;
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Location = new System.Drawing.Point(12, 110);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(54, 13);
            this.serverIPLabel.TabIndex = 4;
            this.serverIPLabel.Text = "Server IP:";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(12, 135);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.portNumberLabel.TabIndex = 5;
            this.portNumberLabel.Text = "Port Number:";
            // 
            // portNumberTextBox
            // 
            this.portNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portNumberTextBox.Location = new System.Drawing.Point(82, 132);
            this.portNumberTextBox.Name = "portNumberTextBox";
            this.portNumberTextBox.Size = new System.Drawing.Size(264, 20);
            this.portNumberTextBox.TabIndex = 6;
            this.portNumberTextBox.Text = "8888";
            // 
            // connectionLabel
            // 
            this.connectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(12, 352);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(79, 13);
            this.connectionLabel.TabIndex = 7;
            this.connectionLabel.Text = "Not Connected";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disconnectButton.Location = new System.Drawing.Point(181, 373);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(163, 23);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // dataSizeLabel
            // 
            this.dataSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSizeLabel.Location = new System.Drawing.Point(97, 352);
            this.dataSizeLabel.Name = "dataSizeLabel";
            this.dataSizeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataSizeLabel.Size = new System.Drawing.Size(247, 13);
            this.dataSizeLabel.TabIndex = 9;
            this.dataSizeLabel.Text = "Data Length Sent: 0";
            this.dataSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.BackgroundImage")));
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(54, 14);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(97, 77);
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(137, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(154, 42);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Spectre";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 410);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.dataSizeLabel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.portNumberTextBox);
            this.Controls.Add(this.portNumberLabel);
            this.Controls.Add(this.serverIPLabel);
            this.Controls.Add(this.serverIPTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spectre - Demo Client";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.TextBox serverIPTextBox;
        private System.Windows.Forms.Label serverIPLabel;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.TextBox portNumberTextBox;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label dataSizeLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

