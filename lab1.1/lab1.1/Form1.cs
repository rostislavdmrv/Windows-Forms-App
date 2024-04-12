namespace lab1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 Class1 = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double value1 = double.Parse(textBox1.Text), value2 = double.Parse(textBox2.Text);
                textBox3.Text = Class1.AddNumbers(button1.Text, value1, value2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter the correct data before pressing the button!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double value1 = double.Parse(textBox1.Text), value2 = double.Parse(textBox2.Text);
                textBox3.Text = Class1.AddNumbers(button2.Text, value1, value2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter the correct data before pressing the button!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double value1 = double.Parse(textBox1.Text), value2 = double.Parse(textBox2.Text);
                textBox3.Text = Class1.AddNumbers(button3.Text, value1, value2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter the correct data before pressing the button!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double value1 = double.Parse(textBox1.Text), value2 = double.Parse(textBox2.Text);
                textBox3.Text = Class1.AddNumbers(button4.Text, value1, value2).ToString();
            }
            catch
            {
                MessageBox.Show("Enter the correct data before pressing the button!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(textBox1.Text), value2 = double.Parse(textBox2.Text);
            textBox3.Text = Class1.AddNumbers(comboBox1.Text, value1, value2).ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}