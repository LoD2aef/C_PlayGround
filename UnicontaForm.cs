using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;
using Uniconta.Common.User;
using Uniconta.DataModel;

namespace WinFormServer {
    public partial class UnicontaLoginForm : Form {
        //private string UserName;
        //private string PassWord;
        private Guid APIGuidKey = new Guid("");
        private CrudAPI CrudAPI;
        private Company CurrentCompany;

        public UnicontaLoginForm() {
            InitializeComponent();
        }

        private async void Connection_SessionButton_Click(object sender, EventArgs e) { // Click on the login button
            // instance a UnicontaConnection with the name UnicConn, the UnicontaConnection set it's APITarget to Live.
            UnicontaConnection UnicConn = new UnicontaConnection(APITarget.Live); // Live is the only Uniconta server.
            Session UnicSess = new Session(UnicConn); // instance a Uniconta Session, where we store the UnicConn.
            string UserName = UnicontaUsernameInput.Text; // take input and store in local variable UserName.
            string PassWord = UnicontaPasswordInput.Text; // take input and store in local variable PassWord.
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(PassWord)) {
                bool UnicontaLogin = await Uniconta_Login(UserName, PassWord, UnicSess);
                if (UnicontaLogin) { // if login successful. 
                    MessageBox.Show("Logged in"); // check for login.
                } else { // if login fails.
                    MessageBox.Show("Not logged in, something wrong");
                }
            } else { // username or password missing
                MessageBox.Show($"one or both missing username : {UserName} password : {PassWord}");
                //  not in use anymore after the code about looks better and function the same, for this perpurse. 
                //  MessageBox.Show(string.Format("one or both missing username : {0} password : {1}", UserName, PassWord));
            }
        }
        private async Task<bool> Uniconta_Login(string username, string password, Session UnicSess) {
            // Attempting to login. gets a ErrorCodes.Succes if login successful. Async method.
            ErrorCodes LoginRes = await UnicSess.LoginAsync(username, password, LoginType.API, APIGuidKey);
            // not in use anymore, after the code about is better as it is Asy. Sync method.
            // ErrorCodes Login = UnicSess.LoginAsync(UserName, PassWord, LoginType.API, APIGuidKey).Result;
            MessageBox.Show(LoginRes.ToString());
            if (LoginRes == ErrorCodes.Succes) {
                return false;
            }
            await InitializeCompany(UnicSess);
            CrudAPI = new CrudAPI(UnicSess, CurrentCompany);

            return true;
        }
        private async Task Uniconta_LogOut(Session UnicSess) {
            await UnicSess.LogOut();
        }
        private async Task InitializeCompany(Session UnicSess) {
            // If Session has a default company, use DefaultComapny as CurrentCompany
            if (UnicSess.DefaultCompany != null) {
                CurrentCompany = UnicSess.DefaultCompany;
                return;
            }

            // TODO: Change Company ID 0 to your company's ID
            CurrentCompany = await UnicSess.OpenCompany(-1, false);
        }
    }
}