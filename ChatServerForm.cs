﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class ChatServerForm : Form {
        public ChatServerForm() {
            InitializeComponent();
        }

        private void StartServerButton_Click(object sender, EventArgs e) {
            StatusOfServerLabel.Text = "Online";
            //string totalInfo = StatusTextBox.Text;
            //totalInfo += "";
            StatusTextBox.Text += "Starting Server Open\n" + Environment.NewLine;
            StatusTextBox.Text += "Server open and runing\n" + Environment.NewLine;
        }

        private void StopServerButton_Click(object sender, EventArgs e) {
            StatusOfServerLabel.Text = "Offline";
            StatusTextBox.Text += "Shutting Server Down\n" + Environment.NewLine;
            StatusTextBox.Text += "Server is Shutdown\n" + Environment.NewLine;
        }

        private void ClearLogButton_Click(object sender, EventArgs e) {
            StatusTextBox.Text = "";
        }
    }
}
