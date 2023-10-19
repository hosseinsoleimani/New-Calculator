using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void numBtnClick(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = ((Button)sender).Text;
            }
            else
            txtScreen.Text += ((Button)sender).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void opBtnClick(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtScreen.Text);
            op =Convert.ToChar( ((Button)sender).Text);
            txtScreen.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2 = 0;
            num2 = Convert.ToDouble(txtScreen.Text);
            switch (op)
            {
                case '+':
                    num1 = num1 + num2;
                    break;
                case '-':
                    num1 = num1 - num2;
                    break;
                case '/':
                    num1 = num1 / num2;
                    break;
                case '*':
                    num1 = num1 * num2;
                    break;
            }
            txtScreen.Text = num1.ToString();
        }
    }
}
