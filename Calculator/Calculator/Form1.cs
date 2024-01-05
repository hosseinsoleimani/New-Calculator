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
        ICalculate calculate;
        double value1=0 ;
        double value2=0 ;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void numBtnClick(object sender, EventArgs e)
        {

            if ((operation_pressed))
            {
                txtScreen.Clear();
                Button b = (Button)sender;
                txtScreen.Text = txtScreen.Text + b.Text;
                value2 = double.Parse(txtScreen.Text);
                operation_pressed = false;
            }
            else
            {
                txtScreen.Clear();
                Button b = (Button)sender;
                txtScreen.Text = txtScreen.Text + b.Text;
                value1 = double.Parse(txtScreen.Text);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
            txtScreen.Text = "0";
          
        }

        private void opBtnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            //value1 = Double.Parse(txtScreen.Text);
            if ((operation_pressed))
            {
                switch (operation)
                {
                    case "+":
                        int sum = calculate.plus((int)value1, (int)value2);
                        txtScreen.Text = sum.ToString();
                        value1 = double.Parse(txtScreen.Text);
                        break;
                    case "-":
                        int minus = calculate.minus((int)value1, (int)value2);
                        txtScreen.Text = minus.ToString();
                        value1 = double.Parse(txtScreen.Text);
                        break;
                    case "*":
                        int multiple = calculate.multiple((int)value1, (int)value2);
                        txtScreen.Text = multiple.ToString();
                        value1 = double.Parse(txtScreen.Text);
                        break;
                    case "/":
                        int divide = calculate.divde((int)value1, (int)value2);
                        txtScreen.Text = divide.ToString();
                        value1 = double.Parse(txtScreen.Text);
                        break;
                    default:
                        break;
                }
            }
            operation_pressed = true;
            equlation.Text = value1 + " " + operation;
 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            equlation.Text = " ";
            switch (operation)
            {

                case "+":
                    int sum = calculate.plus((int)value1, (int)value2);
                    txtScreen.Text = sum.ToString();
                    value1 = double.Parse( txtScreen.Text);
                    break;
                case "-":
                    int minus = calculate.minus((int)value1, (int)value2);
                    txtScreen.Text = minus.ToString();
                    value1 = double.Parse(txtScreen.Text);
                    break;
                case "*":
                    int multiple = calculate.multiple((int)value1, (int)value2);
                    txtScreen.Text = multiple.ToString();
                    value1 = double.Parse(txtScreen.Text);
                    break;
                case "/":
                    int divide = calculate.divde((int)value1, (int)value2);
                    txtScreen.Text = divide.ToString();
                    value1 = double.Parse(txtScreen.Text);
                    break;
                default:
                    break;

                    
            }
         
        }
    }
}
