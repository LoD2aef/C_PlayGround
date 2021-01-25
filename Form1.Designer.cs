﻿namespace WinFormServer
{
    partial class Form1
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
            this.WinFormCalculatorButton = new System.Windows.Forms.Button();
            this.PrintFunctionAndCallButton = new System.Windows.Forms.Button();
            this.MessageBoxPrintInfoButton = new System.Windows.Forms.Button();
            this.WinFormTextFormatButton = new System.Windows.Forms.Button();
            this.WinFormUnicontaButton = new System.Windows.Forms.Button();
            this.WinFormAsync_SyncButton = new System.Windows.Forms.Button();
            this.WinFormSessionButton = new System.Windows.Forms.Button();
            this.WinFormChatServerButton = new System.Windows.Forms.Button();
            this.WinFormChatClientButton = new System.Windows.Forms.Button();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WinFormCalculatorButton
            // 
            this.WinFormCalculatorButton.Location = new System.Drawing.Point(13, 13);
            this.WinFormCalculatorButton.Name = "WinFormCalculatorButton";
            this.WinFormCalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormCalculatorButton.TabIndex = 0;
            this.WinFormCalculatorButton.Text = "Calculator";
            this.WinFormCalculatorButton.UseVisualStyleBackColor = true;
            this.WinFormCalculatorButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PrintFunctionAndCallButton
            // 
            this.PrintFunctionAndCallButton.Location = new System.Drawing.Point(13, 226);
            this.PrintFunctionAndCallButton.Name = "PrintFunctionAndCallButton";
            this.PrintFunctionAndCallButton.Size = new System.Drawing.Size(75, 23);
            this.PrintFunctionAndCallButton.TabIndex = 1;
            this.PrintFunctionAndCallButton.Text = "Print";
            this.PrintFunctionAndCallButton.UseVisualStyleBackColor = true;
            this.PrintFunctionAndCallButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // MessageBoxPrintInfoButton
            // 
            this.MessageBoxPrintInfoButton.Location = new System.Drawing.Point(13, 197);
            this.MessageBoxPrintInfoButton.Name = "MessageBoxPrintInfoButton";
            this.MessageBoxPrintInfoButton.Size = new System.Drawing.Size(75, 23);
            this.MessageBoxPrintInfoButton.TabIndex = 2;
            this.MessageBoxPrintInfoButton.Text = "Printer Info";
            this.MessageBoxPrintInfoButton.UseVisualStyleBackColor = true;
            this.MessageBoxPrintInfoButton.Click += new System.EventHandler(this.MessageBoxPrintInfoButton_Click);
            // 
            // WinFormTextFormatButton
            // 
            this.WinFormTextFormatButton.Location = new System.Drawing.Point(13, 42);
            this.WinFormTextFormatButton.Name = "WinFormTextFormatButton";
            this.WinFormTextFormatButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormTextFormatButton.TabIndex = 3;
            this.WinFormTextFormatButton.Text = "Text Format";
            this.WinFormTextFormatButton.UseVisualStyleBackColor = true;
            this.WinFormTextFormatButton.Click += new System.EventHandler(this.WinFormTextFormatButton_Click);
            // 
            // WinFormUnicontaButton
            // 
            this.WinFormUnicontaButton.Location = new System.Drawing.Point(113, 226);
            this.WinFormUnicontaButton.Name = "WinFormUnicontaButton";
            this.WinFormUnicontaButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormUnicontaButton.TabIndex = 4;
            this.WinFormUnicontaButton.Text = "Uniconta";
            this.WinFormUnicontaButton.UseVisualStyleBackColor = true;
            this.WinFormUnicontaButton.Click += new System.EventHandler(this.WinFormUnicontaButton_Click);
            // 
            // WinFormAsync_SyncButton
            // 
            this.WinFormAsync_SyncButton.Location = new System.Drawing.Point(113, 13);
            this.WinFormAsync_SyncButton.Name = "WinFormAsync_SyncButton";
            this.WinFormAsync_SyncButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormAsync_SyncButton.TabIndex = 5;
            this.WinFormAsync_SyncButton.Text = "Async/Sync";
            this.WinFormAsync_SyncButton.UseVisualStyleBackColor = true;
            this.WinFormAsync_SyncButton.Click += new System.EventHandler(this.WinFormAsync_SyncButton_Click);
            // 
            // WinFormSessionButton
            // 
            this.WinFormSessionButton.Enabled = false;
            this.WinFormSessionButton.Location = new System.Drawing.Point(113, 42);
            this.WinFormSessionButton.Name = "WinFormSessionButton";
            this.WinFormSessionButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormSessionButton.TabIndex = 6;
            this.WinFormSessionButton.Text = "Session";
            this.WinFormSessionButton.UseVisualStyleBackColor = true;
            this.WinFormSessionButton.Click += new System.EventHandler(this.WinFormSessionButton_Click);
            // 
            // WinFormChatServerButton
            // 
            this.WinFormChatServerButton.Location = new System.Drawing.Point(213, 13);
            this.WinFormChatServerButton.Name = "WinFormChatServerButton";
            this.WinFormChatServerButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormChatServerButton.TabIndex = 7;
            this.WinFormChatServerButton.Text = "Chat Server";
            this.WinFormChatServerButton.UseVisualStyleBackColor = true;
            this.WinFormChatServerButton.Click += new System.EventHandler(this.WinFormChatServerButton_Click);
            // 
            // WinFormChatClientButton
            // 
            this.WinFormChatClientButton.Location = new System.Drawing.Point(213, 42);
            this.WinFormChatClientButton.Name = "WinFormChatClientButton";
            this.WinFormChatClientButton.Size = new System.Drawing.Size(75, 23);
            this.WinFormChatClientButton.TabIndex = 8;
            this.WinFormChatClientButton.Text = "Chat Client";
            this.WinFormChatClientButton.UseVisualStyleBackColor = true;
            this.WinFormChatClientButton.Click += new System.EventHandler(this.WinFormChatClientButton_Click);
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(313, 226);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(75, 23);
            this.ShutdownButton.TabIndex = 9;
            this.ShutdownButton.Text = "Luk";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.WinFormChatClientButton);
            this.Controls.Add(this.WinFormChatServerButton);
            this.Controls.Add(this.WinFormSessionButton);
            this.Controls.Add(this.WinFormAsync_SyncButton);
            this.Controls.Add(this.WinFormUnicontaButton);
            this.Controls.Add(this.WinFormTextFormatButton);
            this.Controls.Add(this.MessageBoxPrintInfoButton);
            this.Controls.Add(this.PrintFunctionAndCallButton);
            this.Controls.Add(this.WinFormCalculatorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WinFormCalculatorButton;
        private System.Windows.Forms.Button PrintFunctionAndCallButton;
        private System.Windows.Forms.Button MessageBoxPrintInfoButton;
        private System.Windows.Forms.Button WinFormTextFormatButton;
        private System.Windows.Forms.Button WinFormUnicontaButton;
        private System.Windows.Forms.Button WinFormAsync_SyncButton;
        private System.Windows.Forms.Button WinFormSessionButton;
        private System.Windows.Forms.Button WinFormChatServerButton;
        private System.Windows.Forms.Button WinFormChatClientButton;
        private System.Windows.Forms.Button ShutdownButton;
    }
}

