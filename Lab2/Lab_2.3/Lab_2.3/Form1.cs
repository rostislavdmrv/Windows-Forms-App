using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 1)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.333).ToString();
                else if (comboBox2.SelectedIndex == 2)
                    textBox2.Text = (double.Parse(textBox1.Text) * 12).ToString();
                else if (comboBox2.SelectedIndex == 3)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.0001893).ToString();
                else MessageBox.Show("Converting from feet to feet not posible!");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                    textBox2.Text = (double.Parse(textBox1.Text) * 3).ToString();
                else if (comboBox2.SelectedIndex == 2)
                    textBox2.Text = (double.Parse(textBox1.Text) * 3.5966).ToString();
                else if (comboBox2.SelectedIndex == 3)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.0005682).ToString();
                else MessageBox.Show("Converting from yard to yard not posible!");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 0)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.8341).ToString();
                else if (comboBox2.SelectedIndex == 1)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.278).ToString();
                else if (comboBox2.SelectedIndex == 2)
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.0001579).ToString();
                else MessageBox.Show("Converting from inch to inch not posible!");
            }
            else
            {
                if (comboBox2.SelectedIndex == 3)
                    textBox2.Text = (double.Parse(textBox1.Text) * 1760).ToString();
                else if (comboBox2.SelectedIndex == 1)
                    textBox2.Text = (double.Parse(textBox1.Text) * 1760).ToString();
                else if (comboBox2.SelectedIndex == 2)
                    textBox2.Text = (double.Parse(textBox1.Text) * 6330).ToString();
                else MessageBox.Show("Converting from mile to mile not posible!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
