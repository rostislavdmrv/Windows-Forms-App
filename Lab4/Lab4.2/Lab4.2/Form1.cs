using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            Button button1 = new Button();
            Button button2 = new Button();
            CreateButton_1();
            CreateButton_2();
        }

        private void CreateButton_1()
        {
            button1.Size = new System.Drawing.Size(120, 30);
            button1.Location = new System.Drawing.Point(10, 10);
            button1.Text = "Create ListBox";
            this.Controls.Add(button1);
  
            button1.Click += new EventHandler(this.button1_Click);
        }

        private void CreateButton_2()
        {
            button2.Size = new System.Drawing.Size(120, 30);
            button2.Location = new System.Drawing.Point(250, 10);
            button2.Text = "Add Salary";
            this.Controls.Add(button2);

            button2.Click += new EventHandler(this.button2_Click);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            CreateListBox_1();
            string[] lines = System.IO.File.ReadAllLines("D:\\tsp\\Lab4.2\\file_salary.txt");
            foreach (string str in lines)
            {
                listBox1.Items.Add(str);
            }
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            CreateListBox_2();

            string name = Interaction.InputBox("Enter a salary: ");
            listBox2.Items.Add(name);
        }

        private void CreateListBox_1()
        {
            listBox1.Size = new System.Drawing.Size(100, 100);
            listBox1.Location = new System.Drawing.Point(10, 50);
            this.Controls.Add(listBox1);
            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void CreateListBox_2()
        {
            listBox2.Size = new System.Drawing.Size(100, 100);
            listBox2.Location = new System.Drawing.Point(270, 50);
            this.Controls.Add(listBox2);
            listBox2.MultiColumn = true;
            listBox2.SelectionMode = SelectionMode.MultiExtended;
        }

    }
}
