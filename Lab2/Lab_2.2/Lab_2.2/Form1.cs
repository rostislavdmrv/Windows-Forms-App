using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = (number*1.8 + 32).ToString();
                label3.Text = number.ToString() + "from C to F =";
            }
            else
            {
                textBox2.Text = (number -33.8).ToString();
                label3.Text = number.ToString() + "from F to C =";
            }

        }
    }
}
