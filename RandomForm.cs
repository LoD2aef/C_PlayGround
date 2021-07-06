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
    public partial class RandomForm : Form {
        Random rnd = new Random();
        string[] cities = new string[] { "Halkevad", "Skørpinge", "Harrested", "Slagelse", "Havrebjerg",
            "Løve", "Høng", "Rye", "Gørlev", "Bjerge", "Svallerup", "Ugerløse", "Rørby", "Kalundborg" };
        public RandomForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = GetRandomItem(cities);
        }

        private T GetRandomItem<T>(T[] data) {
            return data[rnd.Next(0, data.Length)];
        }
    }
}
