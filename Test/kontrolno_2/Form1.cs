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
    public partial class Form1 : Form
    {
        private validateData validation;

        public Form1()
        {
            InitializeComponent();
            validation = new validateData(errorProvider1);
        }


        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (validation.isEmptyField(tb_name))
                e.Cancel = true;
            else e.Cancel = false;
            validation.upperLetter(tb_name);
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateLetters(tb_name, e.KeyChar);
        }       

        private void tb_middle_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateLetters(tb_middle_name, e.KeyChar);
        }

        private void tb_middle_name_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (validation.isEmptyField(tb_middle_name))
                e.Cancel = true;
            else e.Cancel = false;
            validation.upperLetter(tb_middle_name);
        }

        private void tb_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateLetters(tb_surname, e.KeyChar);
        }

        private void tb_surname_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (validation.isEmptyField(tb_surname))
                e.Cancel = true;
            else e.Cancel = false;
            validation.upperLetter(tb_surname);

        }

        private void tb_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateLetters(tb_address, e.KeyChar);

        }

        private void tb_address_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (validation.isEmptyField(tb_address))
                e.Cancel = true;
            else e.Cancel = false;
        }

        private void tb_egn_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateNumbers(tb_egn, e.KeyChar);
        }

        private void tb_egn_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            validation.validateLenghtEGN(tb_egn);
            if (validation.isEmptyField(tb_egn))
                e.Cancel = true;
            else e.Cancel = false;

        }

        private void b_scolarship_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
