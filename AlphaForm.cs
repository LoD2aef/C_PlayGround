using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class AlphaForm : Form {
        public AlphaForm() {
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

        private void BigOAlgorithms_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                BigOAlgorithms BOA = new BigOAlgorithms();
                Application.Run(BOA);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void MultiSelect_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                MultiSelectForm MSF = new MultiSelectForm();
                Application.Run(MSF);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void TimerFormButton_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                TimerForm TF = new TimerForm();
                Application.Run(TF);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void ClassAndObject_Click(object sender, EventArgs e) {
            object x = new Dog();
            bool a1 = x is Dog; // true
            bool a2 = x is Animal; // true
            bool b1 = x.GetType() == typeof(Dog); // true
            bool b2 = x.GetType() == typeof(Animal); // false
            var t = typeof(Animal); // Name = "Animal"
            var t2 = typeof(Dog); // Name = "Dog"
            bool c1 = t == typeof(Dog);  // false
            bool c2 = t2 == typeof(Dog); // true
            bool c3 = t == typeof(Animal); // true
            bool c4 = t2 == typeof(Animal); // false
            bool d1 = typeof(Dog).IsAssignableFrom(x.GetType()); // true
            bool d2 = typeof(Animal).IsAssignableFrom(x.GetType()); // true
            bool e1 = t.IsAssignableFrom(x.GetType()); // true
            bool e2 = t2.IsAssignableFrom(x.GetType()); // true
        }

        private void SecureStringButton_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                SecureStringForm SSF = new SecureStringForm();
                Application.Run(SSF);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void RandomButton_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                RandomForm RF = new RandomForm();
                Application.Run(RF);
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
    class Animal {
        int legs;
    }
    class Dog : Animal {
        string Size;
    }
}