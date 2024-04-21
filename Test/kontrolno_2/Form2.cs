using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2_Mihaela_Hristova_21621562
{
    public partial class Form2 : Form
    {
        private validateData validation;

        public Form2()
        {
            InitializeComponent();
            tb_total.Enabled = false;
            this.validation = new validateData(errorProvider1);

        }

        private void tb_mainScolarship_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateNumbers(tb_mainScolarship, e.KeyChar);
            validation.validateDot(tb_additional, e.KeyChar);

        }

        private void tb_additional_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateNumbers(tb_additional, e.KeyChar);
            validation.validateDot(tb_additional,e.KeyChar);
        }

        private void tb_taxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateNumbers(tb_taxes, e.KeyChar);
            validation.validateDot(tb_additional, e.KeyChar);

        }

        private void b_end_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_mainScolarship_TextChanged(object sender, EventArgs e)
        {
            tb_total.Text=calculateScolarship().ToString();
        }

        private void tb_additional_TextChanged(object sender, EventArgs e)
        {
            tb_total.Text = calculateScolarship().ToString();
        }

        private void tb_taxes_TextChanged(object sender, EventArgs e)
        {
            tb_total.Text = calculateScolarship().ToString();
        }

        private double calculateScolarship()
        {
            return double.Parse(tb_mainScolarship.Text) + double.Parse(tb_additional.Text) - double.Parse(tb_taxes.Text);
        }
    }
}
