using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class CalculatorForm : Form {
        string inputValue;
        string resultValue;
        bool ActionIsActive;
        public CalculatorForm() {
            InitializeComponent();
        }
        private void TheConfusedButton_Click(object sender, EventArgs e) {
            MessageBox.Show("for additional information E-Mail pj@boesgaard.dk with you're Question");
        }

        private void TheZeroButton_Click(object sender, EventArgs e) {
            TheMathInputValue(0);
        }

        private void TheOneButton_Click(object sender, EventArgs e) {
            TheMathInputValue(1);
        }

        private void TheTwoButton_Click(object sender, EventArgs e) {
            TheMathInputValue(2);
        }

        private void TheThreeButton_Click(object sender, EventArgs e) {
            TheMathInputValue(3);
        }

        private void TheFourButton_Click(object sender, EventArgs e) {
            TheMathInputValue(4);
        }

        private void TheFiveButton_Click(object sender, EventArgs e) {
            TheMathInputValue(5);
        }

        private void TheSixButton_Click(object sender, EventArgs e) {
            TheMathInputValue(6);
        }

        private void TheSevenButton_Click(object sender, EventArgs e) {
            TheMathInputValue(7);
        }

        private void TheEightButton_Click(object sender, EventArgs e) {
            TheMathInputValue(8);
        }

        private void TheNineButton_Click(object sender, EventArgs e) {
            TheMathInputValue(9);
        }


        private void TheAddMathButton_Click(object sender, EventArgs e) {

        }

        private void TheSubtractMathButton_Click(object sender, EventArgs e) {

        }

        private void TheMultipleMathButton_Click(object sender, EventArgs e) {

        }

        private void TheDivisionMathButton_Click(object sender, EventArgs e) {

        }

        private void TheDismalMathButton_Click(object sender, EventArgs e) {

        }
        private void TheEqualMathButton_Click(object sender, EventArgs e) {

        }

        private void TheClearLineButton_Click(object sender, EventArgs e) {
            TheMathInputAction("Clear");
        }

        private void TheClearAllMathButton_Click(object sender, EventArgs e) {
            TheMathInputAction("ClearAll");
        }
        private void TheMathInputValue(int value) {
            if (value != 0) {
                inputValue += value.ToString();
                TheMathInputTextBox.Text = inputValue;
            } else if (value == 0 && inputValue != "0" && !string.IsNullOrEmpty(inputValue)) {
                inputValue += value.ToString();
                TheMathInputTextBox.Text = inputValue;
            } else {
                TheMathInputTextBox.Text = value.ToString();
            }
        }
        private void TheMathInputAction(string action) {
            if (ActionIsActive != true) {
                switch (action) {
                    case "ClearAll":
                        inputValue = "";
                        resultValue = "";
                        TheMathInputTextBox.Text = inputValue;
                        TheMathLineTextBox.Text = resultValue;
                        break;
                    case "Clear":
                        inputValue = "";
                        TheMathInputTextBox.Text = inputValue;
                        break;
                    case "Adding":
                        break;
                    case "Subtracting":
                        break;
                    case "Multiple":
                        break;
                    case "Division":
                        break;
                    case "Dismal":
                        break;
                    case "Equal":
                        break;
                    default:
                        break;
                }
            } else {
                MessageBox.Show("another action is in use");
            }
        }
    }
}
