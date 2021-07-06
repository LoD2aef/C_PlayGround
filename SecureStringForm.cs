using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class SecureStringForm : Form {
        public SecureStringForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Instantiate the secure string.  
            SecureString password = new SecureString();
            password.AppendChar('c');
            password.AppendChar('b');
            password.AppendChar('a');
            password.AppendChar('d');
            password.AppendChar('p');
            password.AppendChar('j');
            try {
                Process.Start("Notepad.exe", "Test", password, "local");
            } catch (Win32Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
