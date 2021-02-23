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

        private async void button2_Click(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_Table(); // call method to create items in uniconta
            MessageBox.Show(res); // display result to user
            Console.WriteLine(res); // internel info for testing
        }

        private async void button3_Click(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_TablePopulate(); // call method to create items in uniconta
            MessageBox.Show(res); // display result to user
            Console.WriteLine(res); // internel info for testing
        }

        private void button4_Click(object sender, EventArgs e) {
            UniAct.Uniconta_InsertCSVFile();
        }

        private async void button5_ClickAsync(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_GetDebitorsAsync();
            MessageBox.Show(res);
        }
    }
}
