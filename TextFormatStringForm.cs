using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class TextFormatStringForm : Form {
        public TextFormatStringForm() {
            InitializeComponent();
            string[] itemsRange = new string[] { "String", "Int", "Double" };
            comboBox1.Items.AddRange(itemsRange);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            //MessageBox.Show(comboBox1.GetItemText(comboBox1.SelectedItem));
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            //int a = comboBox1.SelectedIndex;
            //MessageBox.Show( comboBox1.Text + " " + a);
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Double") {
                try {
                    double value;
                    value = double.Parse(textBox1.Text);
                    // Console.WriteLine("InvariantCulture :" + value.ToString("0,0.000", CultureInfo.InvariantCulture));
                    // Console.WriteLine("CurrentCulture   :" + String.Format(CultureInfo.CurrentCulture, "{0:0,0.000}", value));
                    FormatResultTextBox.Text = String.Format(CultureInfo.CurrentCulture, "{0:0,0.000}", value);
                } catch {
                    MessageBox.Show("input was not a double check if you select the rigth format or input");
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
