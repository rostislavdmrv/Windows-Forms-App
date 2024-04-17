using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            TextBox textbox1 = new TextBox();
            TextBox textbox2 = new TextBox();
            CreateButton();
        }

        private void CreateButton()
        {
            button1.Size = new System.Drawing.Size(120, 30);
            button1.Location = new System.Drawing.Point(10, 10);
            button1.Text = "Create ListBox";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(this.button1_Click);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            CreateTextBox_1();
            CreateTextBox_2();
        }

        private void CreateTextBox_1() { 
            textBox1.Size = new System.Drawing.Size(100, 100);
            textBox1.Location = new System.Drawing.Point(10, 50);
            this.Controls.Add(textBox1);
        }

        private void CreateTextBox_2()
        {
            textBox2.Size = new System.Drawing.Size(100, 100);
            textBox2.Location = new System.Drawing.Point(10, 100);
            this.Controls.Add(textBox2);
        }

        private void CalculateTrifonometry(double number)
        {
            if (number < -360 || number > 360) throw new ArgumentException("Invalid data!");
            double cos = 0, sin = 0, tg = 0;
            MessageBox.Show("Trigonometric functions:\n" +
                            "cos" + number + " = " + cos + "\n" +
                            "sin" + number + " = " + sin + "\n" +
                            "tg" + number + " = " + tg);
        }

        private void CalculateCircle(double number)
        {
            if (number < 1 || number > 10) throw new ArgumentException("Invalid data!");
            double S = Math.PI*Math.Pow(number,2), P = 2*Math.PI*number;
            MessageBox.Show("S and P of a circle:\n" +
                            "S" + " = " + S + "\n" +
                            "P" + " = " + P);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateTrifonometry(Double.Parse(textBox1.Text));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateCircle(Double.Parse(textBox2.Text));
        }
    }
}
