using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(textBox1.Text);
            double ddp=0, ddo=0, healthI = 0;
            if (radioButton1.Checked && textBox1 != null)
            {
                ddp = salary * 0.089;
                label8.Text = ddp + "лв.".ToString();
                ddo = 0.0;
                label9.Text = ddo + "лв.".ToString();
            }
            else if (radioButton2.Checked && textBox1.Text != null)
            {
                ddp = salary * 0.067;
                label8.Text = ddp + "лв.".ToString();
                ddo = salary * 0.022;
                label9.Text = ddo + "лв.".ToString();
            }
            healthI = salary * 0.032;
            label10.Text = healthI + "лв.".ToString();
            label11.Text = ddp + ddo + healthI + "лв.".ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                textBox1.Focus();
            }
        }

    }
}
