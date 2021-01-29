namespace WinFormServer {
    partial class UnicontaLoginForm {
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
            this.UnicontaLoginButton = new System.Windows.Forms.Button();
            this.UnicontaUsernameInput = new System.Windows.Forms.TextBox();
            this.UnicontaUsernameLabel = new System.Windows.Forms.Label();
            this.UnicontaPasswordLabel = new System.Windows.Forms.Label();
            this.UnicontaPasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnicontaLoginButton
            // 
            this.UnicontaLoginButton.Location = new System.Drawing.Point(15, 72);
            this.UnicontaLoginButton.Name = "UnicontaLoginButton";
            this.UnicontaLoginButton.Size = new System.Drawing.Size(202, 23);
            this.UnicontaLoginButton.TabIndex = 0;
            this.UnicontaLoginButton.Text = "Login";
            this.UnicontaLoginButton.UseVisualStyleBackColor = true;
            this.UnicontaLoginButton.Click += new System.EventHandler(this.Connection_SessionButton_Click);
            // 
            // UnicontaUsernameInput
            // 
            this.UnicontaUsernameInput.Location = new System.Drawing.Point(73, 9);
            this.UnicontaUsernameInput.Name = "UnicontaUsernameInput";
            this.UnicontaUsernameInput.Size = new System.Drawing.Size(144, 20);
            this.UnicontaUsernameInput.TabIndex = 1;
            // 
            // UnicontaUsernameLabel
            // 
            this.UnicontaUsernameLabel.AutoSize = true;
            this.UnicontaUsernameLabel.Location = new System.Drawing.Point(12, 9);
            this.UnicontaUsernameLabel.Name = "UnicontaUsernameLabel";
            this.UnicontaUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UnicontaUsernameLabel.TabIndex = 3;
            this.UnicontaUsernameLabel.Text = "Username";
            // 
            // UnicontaPasswordLabel
            // 
            this.UnicontaPasswordLabel.AutoSize = true;
            this.UnicontaPasswordLabel.Location = new System.Drawing.Point(12, 49);
            this.UnicontaPasswordLabel.Name = "UnicontaPasswordLabel";
            this.UnicontaPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.UnicontaPasswordLabel.TabIndex = 4;
            this.UnicontaPasswordLabel.Text = "Password";
            // 
            // UnicontaPasswordInput
            // 
            this.UnicontaPasswordInput.Location = new System.Drawing.Point(73, 46);
            this.UnicontaPasswordInput.Name = "UnicontaPasswordInput";
            this.UnicontaPasswordInput.Size = new System.Drawing.Size(144, 20);
            this.UnicontaPasswordInput.TabIndex = 5;
            this.UnicontaPasswordInput.UseSystemPasswordChar = true;
            // 
            // UnicontaLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 112);
            this.Controls.Add(this.UnicontaPasswordInput);
            this.Controls.Add(this.UnicontaPasswordLabel);
            this.Controls.Add(this.UnicontaUsernameLabel);
            this.Controls.Add(this.UnicontaUsernameInput);
            this.Controls.Add(this.UnicontaLoginButton);
            this.Name = "UnicontaLoginForm";
            this.Text = "Uniconta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnicontaLoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnicontaLoginButton;
        private System.Windows.Forms.TextBox UnicontaUsernameInput;
        private System.Windows.Forms.Label UnicontaUsernameLabel;
        private System.Windows.Forms.Label UnicontaPasswordLabel;
        private System.Windows.Forms.TextBox UnicontaPasswordInput;
    }
}