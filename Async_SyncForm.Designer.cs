namespace WinFormServer {
    partial class Async_SyncForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AsyncButton = new System.Windows.Forms.Button();
            this.SyncButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ParallelAsyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AsyncButton
            // 
            this.AsyncButton.Location = new System.Drawing.Point(12, 100);
            this.AsyncButton.Name = "AsyncButton";
            this.AsyncButton.Size = new System.Drawing.Size(75, 23);
            this.AsyncButton.TabIndex = 0;
            this.AsyncButton.Text = "Async";
            this.AsyncButton.UseVisualStyleBackColor = true;
            this.AsyncButton.Click += new System.EventHandler(this.AsyncButton_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(12, 12);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 23);
            this.SyncButton.TabIndex = 1;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 114);
            this.textBox1.TabIndex = 2;
            // 
            // ParallelAsyncButton
            // 
            this.ParallelAsyncButton.Location = new System.Drawing.Point(161, 100);
            this.ParallelAsyncButton.Name = "ParallelAsyncButton";
            this.ParallelAsyncButton.Size = new System.Drawing.Size(100, 23);
            this.ParallelAsyncButton.TabIndex = 3;
            this.ParallelAsyncButton.Text = "Parallel Async";
            this.ParallelAsyncButton.UseVisualStyleBackColor = true;
            this.ParallelAsyncButton.Click += new System.EventHandler(this.ParallelAsyncButton_Click);
            // 
            // Async_SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 258);
            this.Controls.Add(this.ParallelAsyncButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SyncButton);
            this.Controls.Add(this.AsyncButton);
            this.Name = "Async_SyncForm";
            this.Text = "Async_Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AsyncButton;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ParallelAsyncButton;
    }
}