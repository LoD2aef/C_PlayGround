using System;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class UnicontaLoggedInForm : Form {
        private static UnicontaActionHandler UniAct; // local variable for the Handle class
        public UnicontaLoggedInForm() {
            InitializeComponent(); // start the form
            UniAct = UnicontaActionHandler.Uniconta_GetInstanceHandler(); // get the instands of the Handler Class
        }
        private async void button1_Click(object sender, EventArgs e) { 
            string res = await UniAct.Uniconta_Populate(); // call method to create items in uniconta
            MessageBox.Show(res); // display result to user
            Console.WriteLine(res); // internel info for testing
        }
    }
}
