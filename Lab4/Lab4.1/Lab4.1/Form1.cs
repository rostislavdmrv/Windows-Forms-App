﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = (textBox1.Text).ToLower();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            if (s == new String(arr)) MessageBox.Show("Yes. Pilindrom!");
            else MessageBox.Show("No. The word is not pilindrom!");
            
        }
    }

}
