using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kontrolno_1
{
    public partial class Form2 : Form
    {
        int num;
        public Form2(int number)
        {
            this.num = number;  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.num % 2 == 0)
                {
                    MessageBox.Show("the number is Even " + this.num);
                    
                }
                else
                {
                    MessageBox.Show("The number is Odd " + this.num);
                   
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input!");
            }
        }
    }
}
