namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeFormColor(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                this.BackColor = (sender as Button).BackColor;
                //this.Text = sender.ToString();
                this.Text = (sender as Button).Text;// това взема
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello students!THIS IS YOUR FIRST C # PROGRAM! Be Happy!)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.LightCoral;
            ChangeFormColor(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.LightBlue;
            ChangeFormColor(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.Text = "Click one of the buttons bellow \n to see the magic working...";
            label1.Font = new Font("Arial", 14);
            label1.ForeColor = Color.White;
        }
    }
}