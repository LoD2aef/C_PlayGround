
namespace WinFormServer {
    partial class ReadFileForm {
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
            this.SelectReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectReadFile
            // 
            this.SelectReadFile.Location = new System.Drawing.Point(12, 12);
            this.SelectReadFile.Name = "SelectReadFile";
            this.SelectReadFile.Size = new System.Drawing.Size(75, 23);
            this.SelectReadFile.TabIndex = 0;
            this.SelectReadFile.Text = "Select File";
            this.SelectReadFile.UseVisualStyleBackColor = true;
            this.SelectReadFile.Click += new System.EventHandler(this.SelectReadFile_Click);
            // 
            // ReadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 365);
            this.Controls.Add(this.SelectReadFile);
            this.Name = "ReadFileForm";
            this.Text = "ReadFileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectReadFile;
    }
}