using System;
using System.Threading;
using System.Windows.Forms;


namespace WinFormServer {
    public partial class UnicontaLoginForm : Form {

        public UnicontaLoginForm() {
            InitializeComponent();
        }
        private async void Connection_SessionButton_Click(object sender, EventArgs e) { // Click on the login button
            string username = UnicontaUsernameInput.Text;
            string password = UnicontaPasswordInput.Text;
            string loginRes = await UnicontaAction.Uniconta_GetInstance().Uniconta_Login(username, password);
            if (loginRes == "Login was Succesful") {
                var t = new Thread(() => Application.Run(new UnicontaActionForm()));
                t.Start();
                Close();
            }
            MessageBox.Show(loginRes);
        }

        private void UnicontaLoginForm_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("UnicontaLoginForm is Closed");
        }
    }
}