﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0;
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if (radioButton1.Checked) result = Math.Pow(a + b, 2);
            else if (radioButton2.Checked) result = Math.Pow(a - b, 2);
            else if (radioButton3.Checked) result = (a + b) * (a - b);
            else if (radioButton4.Checked) result = Math.Pow(a + b, 3);
            else if (radioButton5.Checked) result = Math.Pow(a - b, 3);
            else if (radioButton6.Checked) result = Math.Pow(a, 3) + Math.Pow(b, 3);
            else if (radioButton7.Checked) result = Math.Pow(a, 3) - Math.Pow(b, 3);
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
