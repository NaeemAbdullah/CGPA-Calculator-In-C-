using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT_NO_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int sum = num1 + num2;
                label4.Text = "Your Answer is: " + sum.ToString();
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int sub = num1 - num2;
                label4.Text = "Your Answer is: " + sub.ToString();
                label4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int m = num1 * num2;
                label4.Text = "Your Answer is: " + m.ToString();
                label4.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                if(num2==0)
                {
                    MessageBox.Show("Cannot Divide By Zero ");
                }
                else
                {
                    int div = num1 / num2;
                    label4.Text = "Your Answer is: " + div.ToString();
                    label4.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                //First convert string to double
                double num1 = Convert.ToDouble(textBox1.Text);
                 double num2 = Convert.ToDouble(textBox2.Text);
                //The function used for exponent is
                double pow = Math.Pow(num1 , num2);
                label4.Text = "Your Answer is: " + pow.ToString();
                label4.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Operands Are Mandatory ");
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot Divide By Zero ");
                }
                else
                {
                    int mod = num1 % num2;
                    label4.Text = "Your Answer is: " + mod.ToString();
                    label4.Visible = true;
                }
            }
        }
    }
}
