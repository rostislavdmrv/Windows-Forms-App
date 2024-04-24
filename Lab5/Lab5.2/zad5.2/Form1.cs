using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5._2
{
    public partial class Form1 : Form
    {
        int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomizer = new Random();
           

            label3.Text = randomizer.Next(51).ToString();
            label5.Text = randomizer.Next(51).ToString();
            label7.Text = randomizer.Next(51).ToString();
            label9.Text = randomizer.Next(51).ToString();
            label11.Text = randomizer.Next(51).ToString();
            label13.Text = randomizer.Next(51).ToString();
            label15.Text = randomizer.Next(51).ToString();
            label17.Text = randomizer.Next(51).ToString();





        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
