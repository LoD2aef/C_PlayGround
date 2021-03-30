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

        private async void button6_ClickAsync(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_UpdateDebitorAsync();
            MessageBox.Show(res);
        }

        private async void button7_ClickAsync(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_Insert_Debitor();
            MessageBox.Show(res);
        }

        private async void UnicontaLoggedInForm_FormClosedAsync(object sender, FormClosedEventArgs e) {
            Console.WriteLine("Uniconta Logout Done");
            await UniAct.Uniconta_LogOut();
        }

        private async void button8_Click(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_Delete_Debitor();
            MessageBox.Show(res);
        }
    }
}