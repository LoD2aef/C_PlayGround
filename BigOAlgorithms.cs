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
        private void Bool_Click(object sender, EventArgs e) {
            //textBox1.Clear();
            //Console.WriteLine("Big O(1) start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (10 >= 10) {
                Console.WriteLine("true");
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(true) Time used in Big O Algorithm 0(1) {time} ns \n";
            Console.WriteLine("Time used in Big O(1) Boolean {0} ns", time);
        }
        private void Loop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            //Console.WriteLine("Big O(N) start");
            int runsForKey = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++) {
                ++runsForKey;
                if (i == 100000) {
                    Console.WriteLine("true");
                    break;
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(100000)Time used in Big O Algorithm 0(N) {time} ns \n";
            Console.WriteLine("Time used in Big O(N) Linear search {0} ns. Loop thou " + runsForKey + " to find key", time);
        }
        private void NestedLoop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            //Console.WriteLine("Big O(N^2) start");
            int runsForKey = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++) {
                for (int ii = 0; ii < 10000; ii++) {
                    ++runsForKey;
                    if (i == 8888 && ii == 9999) {
                        break;
                    }
                }
                if (i == 8888) {
                    break;
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(10000*10000)Time used in Big O Algorithm 0(N^2) times is : {time} ns \n";
            Console.WriteLine("Time used in Big O(N^2) Linear search {0} ns. Loop thou " + runsForKey + " to find key", time);
        }
        private void BinaryLoop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            int[] arr = Enumerable.Range(0, 100000 + 1).ToArray(); // creating array from 0 to 100000
            int min = 0; // 0
            int max = arr.Length - 1;
            int key = int.Parse(NumberToFind.Text);
            int runsForKey = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (min <= max) {
                ++runsForKey;
                int mid = (min + max) / 2;
                if (key == arr[mid]) { // if item found
                    break;
                } else if (key < arr[mid]) { // if Key is small then mid 
                    max = mid - 1;
                } else {
                    min = mid + 1;
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(100000)Time used in Big O Algorithm 0(N) {time} ns \n";
            Console.WriteLine("Time used in Big O(N) Binary Search {0} ns. Loop thou " + runsForKey + " to find key", time);
        }
        private void BinaryNestedLoop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            int[] arr = Enumerable.Range(0, 10000 + 1).ToArray(); // creating array from 0 to 100000
            int min = 0;
            int max = arr.Length - 1;
            int key = 9998;
            int runsForKey = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++) {
                while (min <= max) {
                    ++runsForKey;
                    int mid = (min + max) / 2;
                    if (key == arr[mid]) { // if item found
                        break;
                    } else if (key < arr[mid]) { // if Key is small then mid 
                        max = mid - 1;
                    } else {
                        min = mid + 1;
                    }
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(10000*10000)Time used in Big O Algorithm 0(N^2) times is : {time} ns \n";
            Console.WriteLine("Time used in Big O(N^2) Binary Search on Nested Loop {0} ns. Loop thou " + runsForKey + " to find key", time);
        }
        private void BinaryOnBothNestedLoop_Click(object sender, EventArgs e) {
            textBox1.Clear();
            int[] MainArr = Enumerable.Range(0, 10000 + 1).ToArray(); // creating array from 0 to 10000
            int[] arr = Enumerable.Range(0, 10000 + 1).ToArray(); // creating array from 0 to 10000
            int MainMin = 0; // 0
            int min = 0; // 0
            int MainMax = MainArr.Length - 1;
            int max = arr.Length - 1;
            int MainKey = 7642;
            int key = 9998;
            int runsForKey = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (MainMin <= MainMax) {
                int MainMid = (MainMin + MainMax) / 2;
                if (MainKey == MainArr[MainMid]) {
                    while (min <= max) {
                        ++runsForKey;
                        int mid = (min + max) / 2;
                        if (key == arr[mid]) { // if item found
                            break;
                        } else if (key < arr[mid]) { // if Key is small then mid 
                            max = mid - 1;
                        } else {
                            min = mid + 1;
                        }
                    }
                    break;
                } else if (MainKey < MainArr[MainMid]) { // if Key is small then mid 
                    MainMax = MainMid - 1;
                } else {
                    MainMin = MainMid + 1;
                }
            }
            watch.Stop();
            var time = watch.ElapsedTicks;
            textBox1.Text += $"(10000*10000)Time used in Big O Algorithm 0(N^2) times is : {time} ns \n";
            Console.WriteLine("Time used in Big O(N^2) Binary Search on both Loop {0} ns. Loop thou " + runsForKey + " to find key", time);
        }


        // array. mininum. maxinum. key 
        private int BinarySearch(int[] arr, int min, int max, int key) {
            if (max >= min) {
                int mid = (min + max) / 2;
                if (arr[mid] == key) {
                    return mid;
                } else if (arr[mid] > key) {
                    return BinarySearch(arr, min, mid - 1, key);
                } else {
                    return BinarySearch(arr, mid + 1, max, key);
                }
            }
            return -1; // Element is not present in Array
        }
        private int BinarySearchConsoleLog(int[] arr, int min, int max, int key) {
            //int res = BinarySearch(arr, 0, arr.Length - 1, 99998); // int array, lowers number, array length -1, target to find
            if (max >= min) {
                int mid = (min + max) / 2;
                if (arr[mid] == key) {
                    return mid;
                } else if (arr[mid] > key) {
                    Console.WriteLine("mid less then key. Min value :" + min + ". Mid value :" + mid + ". Max value :" + max);
                    return BinarySearch(arr, min, mid - 1, key);
                } else {
                    Console.WriteLine("mid more then key. Min value :" + min + ". Mid value :" + mid + ". Max value :" + max);
                    return BinarySearch(arr, mid + 1, max, key);
                }
            }
            return -1; // Element is not present in Array
        }
    }
}
