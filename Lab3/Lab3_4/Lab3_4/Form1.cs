namespace Lab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = DateTime.Today.Month, year = DateTime.Today.Year, day = DateTime.Today.Day;
            int entered_month= int.Parse(textBox1.Text), entered_day=int.Parse(textBox2.Text), entered_year=int.Parse(textBox3.Text);
            int personYears = year-int.Parse(textBox3.Text), personMonth = 0;

            if (entered_year > year || entered_year < 1900 || entered_month > 12 || entered_month < 0 || entered_day > 31 || entered_day < 0) throw new Exception("Invalid enered data!");
            if (month >= entered_month)
            {
                if(day >= entered_day)
                personMonth = month - entered_month;
                else personMonth = month-entered_month;

            }
            else
            {
                personMonth = 12 - (entered_month-month);
                personYears--;

            }
            MessageBox.Show(personYears + " Years and " + personMonth + "Months");
        }
    }
}