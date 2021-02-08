using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        [Obsolete]
        private void Button1_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                CalculatorForm CalForm = new CalculatorForm();
                Application.Run(CalForm);
            }) {
                ApartmentState = ApartmentState.STA
            };
            thread.Start();
        }

        private void Button1_Click_1(object sender, EventArgs e) {
            var pd = new PrintDocument();
            pd.PrinterSettings.Duplex = Duplex.Vertical;
            pd.PrinterSettings.PrinterName = "UTAX_TA 5006ci";
            /*
            var pd = new PrintDocument{
                PrinterSettings = {
                    Duplex = Duplex.Vertical,
                    PrinterName = "UTAX_TA 5006ci"
                }
            };
            */
            if (pd.PrinterSettings.IsValid) {
                pd.Print();
            }
        }

        private void MessageBoxPrintInfoButton_Click(object sender, EventArgs e) {
            PrinterSettings settings = new PrinterSettings();
            if (settings.CanDuplex) {
            MessageBox.Show(settings.PrinterName + "\nstatus for duplex : " + settings.CanDuplex);
            }
        }

        private void WinFormTextFormatButton_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                TextFormatStringForm TexForStr = new TextFormatStringForm();
                Application.Run(TexForStr);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void WinFormUnicontaButton_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                UnicontaLoginForm UnicontaForm = new UnicontaLoginForm();
                Application.Run(UnicontaForm);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void WinFormAsync_SyncButton_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                Async_SyncForm AsyncSync = new Async_SyncForm();
                Application.Run(AsyncSync);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void WinFormSessionButton_Click(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                SessionForm SessForm = new SessionForm();
                Application.Run(SessForm);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void WinFormChatServerButton_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                ChatServerForm csf = new ChatServerForm();
                Application.Run(csf);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void WinFormChatClientButton_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                ChatClientForm ccf = new ChatClientForm();
                Application.Run(ccf);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void ShutdownButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ReadFileButton_Click(object sender, EventArgs e) {

        }
    }
}