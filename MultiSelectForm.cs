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
    public partial class MultiSelectForm : Form {
        public MultiSelectForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(listBox1.SelectedIndex.ToString() + " - " + listBox1.SelectedItem.ToString());
            MessageBox.Show(checkedListBox1.SelectedIndex.ToString() + " - " + checkedListBox1.CheckedItems.ToString());
        }
    }
}
