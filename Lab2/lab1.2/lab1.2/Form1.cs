using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Check if the number is even or odd!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(textBox1.Text);
                if (number % 2 == 0) label1.Text = "Even!";
                else label1.Text = "Odd!";
            }catch
            {
                label1.Text = "Incorect number";
            }
        }
    }
}
