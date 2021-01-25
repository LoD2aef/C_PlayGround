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
    public partial class UnicontaForm : Form {
        private string UserName;
        private string PassWord;
        private string APIGuidKey = "";

        public UnicontaForm() {
            InitializeComponent();
        }

        private void Connection_SessionButton_Click(object sender, EventArgs e) {
            UnicontaConnection UnicConn = new UnicontaConnection(APITarget.Live);
            Session UnicSess = new Session(UnicConn);
            UserName = UsernameInput.Text;
            PassWord = PasswordInput.Text;
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(PassWord)) {
                ErrorCodes Login = UnicSess.LoginAsync(UserName, PassWord, LoginType.API, new Guid(APIGuidKey)).Result;
                if (Login == ErrorCodes.Succes) {
                    MessageBox.Show("Logged in");
                } else {
                    MessageBox.Show("Not logged in, something wrong");
                }
            } else { // username or password missing
                MessageBox.Show($"one or both missing username : {UserName} password : {PassWord}");
                MessageBox.Show(string.Format("one or both missing username : {0} password : {1}", UserName, PassWord));
            }
        }
    }
}