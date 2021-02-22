﻿
namespace WinFormServer {
    partial class BigOAlgorithms {
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
            this.Bool = new System.Windows.Forms.Button();
            this.Loop = new System.Windows.Forms.Button();
            this.NestedLoop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bool
            // 
            this.Bool.Location = new System.Drawing.Point(13, 13);
            this.Bool.Name = "Bool";
            this.Bool.Size = new System.Drawing.Size(75, 23);
            this.Bool.TabIndex = 0;
            this.Bool.Text = "O(1)";
            this.Bool.UseVisualStyleBackColor = true;
            this.Bool.Click += new System.EventHandler(this.Bool_Click);
            // 
            // Loop
            // 
            this.Loop.Location = new System.Drawing.Point(94, 13);
            this.Loop.Name = "Loop";
            this.Loop.Size = new System.Drawing.Size(75, 23);
            this.Loop.TabIndex = 1;
            this.Loop.Text = "O(N)";
            this.Loop.UseVisualStyleBackColor = true;
            this.Loop.Click += new System.EventHandler(this.Loop_Click);
            // 
            // NestedLoop
            // 
            this.NestedLoop.Location = new System.Drawing.Point(175, 13);
            this.NestedLoop.Name = "NestedLoop";
            this.NestedLoop.Size = new System.Drawing.Size(75, 23);
            this.NestedLoop.TabIndex = 2;
            this.NestedLoop.Text = "O(N^2)";
            this.NestedLoop.UseVisualStyleBackColor = true;
            this.NestedLoop.Click += new System.EventHandler(this.NestedLoop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 238);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "NULL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BigOAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NestedLoop);
            this.Controls.Add(this.Loop);
            this.Controls.Add(this.Bool);
            this.Name = "BigOAlgorithms";
            this.Text = "BigOAlgorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bool;
        private System.Windows.Forms.Button Loop;
        private System.Windows.Forms.Button NestedLoop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}