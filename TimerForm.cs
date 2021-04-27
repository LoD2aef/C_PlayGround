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
    public partial class TimerForm : Form {
        public TimerForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TimerProgram TP = new TimerProgram();
            TP.SetUpTimer(new TimeSpan(9, 51, 00));
        }
    }
}
