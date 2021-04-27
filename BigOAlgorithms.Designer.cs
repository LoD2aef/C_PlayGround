
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
            this.BinaryLoop = new System.Windows.Forms.Button();
            this.BinaryOnNestedLoop = new System.Windows.Forms.Button();
            this.NumberToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BinaryOnBothNestedLoop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bool
            // 
            this.Bool.Location = new System.Drawing.Point(13, 13);
            this.Bool.Name = "Bool";
            this.Bool.Size = new System.Drawing.Size(108, 23);
            this.Bool.TabIndex = 0;
            this.Bool.Text = "O(1)";
            this.Bool.UseVisualStyleBackColor = true;
            this.Bool.Click += new System.EventHandler(this.Bool_Click);
            // 
            // Loop
            // 
            this.Loop.Location = new System.Drawing.Point(127, 13);
            this.Loop.Name = "Loop";
            this.Loop.Size = new System.Drawing.Size(99, 23);
            this.Loop.TabIndex = 1;
            this.Loop.Text = "O(N)";
            this.Loop.UseVisualStyleBackColor = true;
            this.Loop.Click += new System.EventHandler(this.Loop_Click);
            // 
            // NestedLoop
            // 
            this.NestedLoop.Location = new System.Drawing.Point(232, 12);
            this.NestedLoop.Name = "NestedLoop";
            this.NestedLoop.Size = new System.Drawing.Size(130, 23);
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
            this.textBox1.Size = new System.Drawing.Size(349, 238);
            this.textBox1.TabIndex = 3;
            // 
            // BinaryLoop
            // 
            this.BinaryLoop.Location = new System.Drawing.Point(127, 42);
            this.BinaryLoop.Name = "BinaryLoop";
            this.BinaryLoop.Size = new System.Drawing.Size(99, 23);
            this.BinaryLoop.TabIndex = 6;
            this.BinaryLoop.Text = "Binary O(N)";
            this.BinaryLoop.UseVisualStyleBackColor = true;
            this.BinaryLoop.Click += new System.EventHandler(this.BinaryLoop_Click);
            // 
            // BinaryOnNestedLoop
            // 
            this.BinaryOnNestedLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BinaryOnNestedLoop.Location = new System.Drawing.Point(232, 42);
            this.BinaryOnNestedLoop.Name = "BinaryOnNestedLoop";
            this.BinaryOnNestedLoop.Size = new System.Drawing.Size(130, 50);
            this.BinaryOnNestedLoop.TabIndex = 7;
            this.BinaryOnNestedLoop.Text = "Binary on nested Loop O(N^2)";
            this.BinaryOnNestedLoop.UseVisualStyleBackColor = true;
            this.BinaryOnNestedLoop.Click += new System.EventHandler(this.BinaryNestedLoop_Click);
            // 
            // NumberToFind
            // 
            this.NumberToFind.Location = new System.Drawing.Point(163, 72);
            this.NumberToFind.Name = "NumberToFind";
            this.NumberToFind.Size = new System.Drawing.Size(64, 20);
            this.NumberToFind.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number to find out of 100000";
            // 
            // BinaryOnBothNestedLoop
            // 
            this.BinaryOnBothNestedLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BinaryOnBothNestedLoop.Location = new System.Drawing.Point(232, 98);
            this.BinaryOnBothNestedLoop.Name = "BinaryOnBothNestedLoop";
            this.BinaryOnBothNestedLoop.Size = new System.Drawing.Size(130, 50);
            this.BinaryOnBothNestedLoop.TabIndex = 10;
            this.BinaryOnBothNestedLoop.Text = "Binary on Both Loop O(N^2)";
            this.BinaryOnBothNestedLoop.UseVisualStyleBackColor = true;
            this.BinaryOnBothNestedLoop.Click += new System.EventHandler(this.BinaryOnBothNestedLoop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Array Bin Sea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BigOAlgorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BinaryOnBothNestedLoop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberToFind);
            this.Controls.Add(this.BinaryOnNestedLoop);
            this.Controls.Add(this.BinaryLoop);
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
        private System.Windows.Forms.Button BinaryLoop;
        private System.Windows.Forms.Button BinaryOnNestedLoop;
        private System.Windows.Forms.TextBox NumberToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BinaryOnBothNestedLoop;
        private System.Windows.Forms.Button button1;
    }
}