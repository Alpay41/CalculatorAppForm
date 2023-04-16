using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button2.Text;
            }
            else
            {
                textBox1.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button3.Text;
            }
            else
            {
                textBox1.Text += button3.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button5.Text;
            }
            else
            {
                textBox1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button6.Text;
            }
            else
            {
                textBox1.Text += button6.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button9.Text;
            }
            else
            {
                textBox1.Text += button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button10.Text;
            }
            else
            {
                textBox1.Text += button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button11.Text;
            }
            else
            {
                textBox1.Text += button11.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ( ! textBox1.Text.Contains( button13.Text ) )// (,)
            {
                textBox1.Text += button13.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button7.Text;
            }
            else
            {
                textBox1.Text += button7.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button1.Text;
            }
            else
            {
                textBox1.Text += button1.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = button14.Text;
            }
            else
            {
                textBox1.Text += button14.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Text == "♫")
            {
                button18.Text = "123";
                button9.Text = "Do";
                button10.Text = "Re";
                button11.Text = "Mi";
                button5.Text = "Fa";
                button6.Text = "Sol";
                button7.Text = "La";
                button1.Text = "Si";
                button2.Text = "Do#";
                button3.Text = "Mi#";
            }
            else 
            {
                button18.Text = "♫";
                button9.Text = "1";
                button10.Text = "2";
                button11.Text = "3";
                button5.Text = "4";
                button6.Text = "5";
                button7.Text = "6";
                button1.Text = "7";
                button2.Text = "8";
                button3.Text = "9";
            }

        }
    }
}
