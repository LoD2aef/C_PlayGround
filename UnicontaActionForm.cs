using System;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class UnicontaActionForm : Form {
        public UnicontaActionForm() {
            InitializeComponent();
            UniAct = UnicontaAction.Uniconta_GetInstance();
        }

        private static UnicontaAction UniAct;

        private async void button1_Click(object sender, EventArgs e) {
            string res = await UniAct.Uniconta_Populate();
            Console.WriteLine(res);
        }
    }
}
