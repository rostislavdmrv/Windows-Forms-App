using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_5
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
        private int randomNumber = new Random().Next(99) + 1;

        private void button1_Click(object sender, EventArgs e)
        {
            int enteredNumber = int.Parse(textBox1.Text);
            if (enteredNumber > randomNumber)
                MessageBox.Show("It is lower!");
            else if (enteredNumber < randomNumber)
                MessageBox.Show("It is grater!");
            else
            {
                MessageBox.Show("You guess it!");
                Close();
            }
        }
    }
}
