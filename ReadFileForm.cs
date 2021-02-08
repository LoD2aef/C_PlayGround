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
    public partial class ReadFileForm : Form {
        public ReadFileForm() {
            InitializeComponent();
        }
        private void SelectReadFile_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV | *csv";
            var lines = new List<string>();
            foreach (string line in lines) {
                MessageBox.Show(line);
            }
        }
    }
}
