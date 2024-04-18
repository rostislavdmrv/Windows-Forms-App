using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            String size = null, crust = null, selectedToppings = "";
            bool extra_cheese = false;
            
            if (radioButton1.Checked)
            {
                size = "small";
                price += 9.25;
            }
            else if (radioButton2.Checked)
            {
                size = "medium";
                price += 11.50;
            }
            else if (radioButton3.Checked)
            {
                size = "large";
                price += 13.75;
            }

            if (radioButton4.Checked)
                crust = " thin";
            else crust = "thick";

            if (checkBox1.Checked) price += 1.5;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i))
                {
                    selectedToppings += (checkedListBox1.Items[i].ToString() + " ");
                    price += 1;
                }

            richTextBox1.Text = "You order a " + crust + " " + size + " pizza " + (extra_cheese ? "with extra cheese " : " ") + ((!selectedToppings.Equals("")) ? ("and " + checkedListBox1.CheckedItems.Count + " toppings:\n" + selectedToppings):" ") + ".\nYour total is " + price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] lines = System.IO.File.ReadAllLines("D:\\tsp\\Lab4.5\\Lab4.5_toppings.txt");
            foreach (string str in lines)
                checkedListBox1.Items.Add(str);
        }
    }
}
