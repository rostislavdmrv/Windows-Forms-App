using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontrolno_1

{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8) 
            { 
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputText = textBox1.Text.ToLower();
            char[] charArray = inputText.ToCharArray();
            

            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] == 'a' || charArray[i] == 'o' || charArray[i] == 'u' || charArray[i] == 'e' || charArray[i] == 'i')
                    {
         
                        richTextBox1.AppendText(charArray[i].ToString() +" --->"+ i +"\n");
                        count++;

                    }
                }
                richTextBox1.AppendText(count.ToString());

               
            }

            else if (comboBox1.SelectedIndex ==1) 
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] != 'a' && charArray[i] != 'o' && charArray[i] != 'u' && charArray[i] != 'e' && charArray[i] != 'i')
                    {
                        richTextBox1.AppendText(charArray[i].ToString() + " --->" + i + "\n");
                        count++;

                    }
                }
                richTextBox1.AppendText(count.ToString());

            }
            Form2 form2 = new Form2(count);
            form2.ShowDialog();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
