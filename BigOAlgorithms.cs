using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class BigOAlgorithms : Form {
        public BigOAlgorithms() {
            InitializeComponent();
        }

        int[] intArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

        private void Bool_Click(object sender, EventArgs e) {
            //textBox1.Clear();
            Console.WriteLine("Big O(1) start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (intArr.Length >= 10) {
                Console.WriteLine("true");
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"Time used in Big O Algorithm 0(1) {time} ns \n";
            Console.WriteLine("Time used in Big O(1) {0} ns", time);
        }

        private void Loop_Click(object sender, EventArgs e) {
            Console.WriteLine("Big O(N) start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < intArr.Length; i++) {
                if (i == 25) {
                    Console.WriteLine("true");
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"Time used in Big O Algorithm 0(N) {time} ns \n";
            Console.WriteLine("Time used in Big O(N) {0} ns", time);
        }

        private void NestedLoop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            Console.WriteLine("Big O(N^2) start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < intArr.Length; i++) {
                for (int ii = 0; ii < intArr.Length; ii++) {
                    if (i == 25 && ii == 25) {
                        Console.WriteLine("true");
                    }
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"Time used in Big O Algorithm 0(N^2) {time} ns \n";
            Console.WriteLine("Time used in Big O(N^2) {0} ns", time);
        }
    }
}
