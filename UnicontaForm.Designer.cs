namespace WinFormServer {
    partial class UnicontaForm {
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
            this.Connection_SessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connection_SessionButton
            // 
            this.Connection_SessionButton.Location = new System.Drawing.Point(13, 13);
            this.Connection_SessionButton.Name = "Connection_SessionButton";
            this.Connection_SessionButton.Size = new System.Drawing.Size(150, 23);
            this.Connection_SessionButton.TabIndex = 0;
            this.Connection_SessionButton.Text = "Connection / Session";
            this.Connection_SessionButton.UseVisualStyleBackColor = true;
            this.Connection_SessionButton.Click += new System.EventHandler(this.Connection_SessionButton_Click);
            // 
            // UnicontaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 229);
            this.Controls.Add(this.Connection_SessionButton);
            this.Name = "UnicontaForm";
            this.Text = "Uniconta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connection_SessionButton;
    }
}