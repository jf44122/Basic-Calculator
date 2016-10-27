using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        decimal var1;
        decimal var2;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num1,
            //    num2,
            //    sum;
            //num1 = Convert.ToInt32(txtOne.Text);
            //num2 = Convert.ToInt32(txtTwo.Text);
            //sum = num1 + num2;
            //lbl1.Text = sum.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {

            //int num1,
            //    num2,
            //    dif;
            //num1 = Convert.ToInt32(txtOne.Text);
            //num2 = Convert.ToInt32(txtTwo.Text);
            //dif = num1 - num2;
            //lbl1.Text = dif.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            //int num1,
            //    num2,
            //    prod;
            //num1 = Convert.ToInt32(txtOne.Text);
            //num2 = Convert.ToInt32(txtTwo.Text);
            //prod = num1 * num2;
            //lbl1.Text = prod.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            //    int num1,
            //        num2,
            //        quo;
            //    num1 = Convert.ToInt32(txtOne.Text);
            //    num2 = Convert.ToInt32(txtTwo.Text);
            //    txtOne
            //    quo = num1; 
            //    quo /= num2;
            //    lbl1.Text = quo.ToString();
            //
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl1.Text += "7";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl1.Text += "2";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            lbl1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbl1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbl1.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbl1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbl1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbl1.Text += "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(lbl1.Text);
            operation = "+";
            lbl1.Text = "";
            
            
            //tell equal to get started
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            //perform assigned calculation on first and second numbers togethe
            decimal var2 = Convert.ToDecimal(lbl1.Text);
            if (operation == "+")
            {
                decimal val = var1;
                val += var2;
                lbl1.Text = val.ToString();
            }
            else if (operation == "-")
            {
                decimal val = var1;
                val -= var2;
                lbl1.Text = val.ToString();

            }
            else if (operation == "*")
            {
                decimal val = var1;
                val *= var2;
                lbl1.Text = val.ToString();
            }
            else if (operation == "/")
            {
                decimal val = var2;
                val /= var1;
                lbl1.Text = val.ToString();
            }
            else
            {
                lbl1.Text = "something is wrong";
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lbl1.Text += ".";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(lbl1.Text);
            operation = "-";
            lbl1.Text = "";
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(lbl1.Text);
            operation = "*";
            lbl1.Text = "";
        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(lbl1.Text);
            operation = "/";
            lbl1.Text = "";
        }
    }
}
