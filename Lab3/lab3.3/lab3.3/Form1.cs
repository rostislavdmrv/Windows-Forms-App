using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                //textBox1.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year=0,month_num=0, days=0;
            String month_word = null;
            bool leap = false;

            year =int.Parse(textBox1.Text);
            month_num =int.Parse(textBox2.Text);
            if (int.Parse(textBox1.Text) <= 1990) throw new Exception("error");
            if (int.Parse(textBox2.Text) < 0 || int.Parse(textBox2.Text) > 13) throw new Exception("error");

            if (year % 400 == 0) leap = true;
            else if (year % 100 == 0) leap = false;
            else if (year % 4 == 0) leap = true;

            switch (month_num)
            {
                case 1: month_word = "January";
                    break;
                case 2: month_word = "February";
                    break;
                case 3: month_word = "March";
                    break;
                case 4: month_word = "April";
                    break;
                case 5: month_word = "May";
                    break;
                case 6: month_word = "June";
                    break;
                case 7: month_word = "July";
                    break;
                case 8: month_word = "August";
                    break;
                case 9: month_word = "September";
                    break;
                case 10: month_word = "Octomber";
                    break;
                case 11: month_word = "November";
                    break;
                case 12: month_word = "December";
                    break;
            }
            switch (month_num) {
                case 1:case 3: case 5: case 7: case 8: case 10: case 12: days = 31;
                    break;
                case 4: case 6: case 9: case 11: days = 30;
                    break;
                case 2:
                    if (leap) days = 29;
                    else days = 28;
                    break;
            }

            MessageBox.Show("The year is " + (leap ? "leaping" : "not leaping") + ". In " + month_word + " there are " + days + " days!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
