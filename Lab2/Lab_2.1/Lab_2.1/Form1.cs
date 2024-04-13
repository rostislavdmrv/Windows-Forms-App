namespace Lab_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = b * b - 4 * a * c;
            double x1 =(-b - Math.Sqrt(d)) / 2*a;
            double x2 =(-b + Math.Sqrt(d)) / 2 * a;
            label6.Text = x1.ToString();
            label7.Text = x2.ToString();
        }
    }
}