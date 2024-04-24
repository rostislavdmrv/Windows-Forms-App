using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int months = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int days = int.Parse(dateTimePicker1.Value.ToString("dd"));

            if ((months == 1 && days <= 20) || (months == 12 && days >= 22)) {
                richTextBox1.Text = "Козирог";
            }
            else if  ((months == 1 && days >= 21) || (months == 2 && days <= 19))
            {
                richTextBox1.Text = "Водолей";
            }
            else if ((months == 2 && days >= 20) || (months == 3 && days <= 20))
            {
                richTextBox1.Text = "Риби";
            }
            else if ((months == 3 && days >= 21) || (months == 4 && days <= 19))
            {
                richTextBox1.Text = "Овен";
            }
            else if ((months == 4 && days >= 20) || (months == 5 && days <= 20))
            {
                richTextBox1.Text = "Телец";
            }
            else if ((months == 5 && days >= 21) || (months == 6 && days <= 21))
            {
                richTextBox1.Text = "Близнаци";
            }


        }
    }
}
