using System;
using System.Threading;
using System.Windows.Forms;


namespace WinFormServer {
    public partial class UnicontaLoginForm : Form {

        public UnicontaLoginForm() {
            InitializeComponent();
        }
        private async void Connection_SessionButton_Click(object sender, EventArgs e) { // Click on the login button
            string username = UnicontaUsernameInput.Text; // get the username from the input, visable
            string password = UnicontaPasswordInput.Text; // get the password from then input invisable
            // pass the input to the login method and get the string about login succes or failure
            string loginRes = await UnicontaActionHandler.Uniconta_GetInstanceHandler().Uniconta_Login(username, password); 
            if (loginRes == "Login was Succesful") { // check if login was succesful
                var t = new Thread(() => Application.Run(new UnicontaLoggedInForm())); // create a thread for the new form
                t.SetApartmentState(ApartmentState.STA); // to remove ThreadStateException Error in openfiledialog 
                t.Start(); // start the new thread form so it is not depending on this forms thread
                Close(); // close the login form. this will not close the new loggedin form, as it runs on a differin thread
            }
            MessageBox.Show(loginRes); // show what error was, wrong password/username or internel server error
        }

        private void UnicontaLoginForm_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("UnicontaLoginForm is Closed"); // internel testing information
        }
    }
}