using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2_Mihaela_Hristova_21621562
{
    internal class validateData
    {
        ErrorProvider errorProvider;

        public validateData(ErrorProvider error)
        {
            this.errorProvider = error;
        }

        public bool isEmptyField(Control txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "Полето не може да остане празно!");
                return true;
            }
            return false;
        }

        public void validateLetters(Control c, char letter)
        {
            if (letter < 'а' || letter > 'я')
                errorProvider.SetError(c, "Не сте въвели букви!");
        }

        public void upperLetter(Control c)
        {
            if (c.Text != null)
            {
                char letter = c.Text.ToCharArray()[0];
                if (letter < 'А' || letter > 'Я')
                    errorProvider.SetError(c, "Не сте въвели главна буква!");
            }
        }

        public void validateNumbers(Control c,char data)
        {
            if (!char.IsDigit(data)) errorProvider.SetError(c,"ЕГН трябва да съдържа само числа!");
        }

        public void validateLenghtEGN(Control c)
        {
            if (c.Text.Length != 10) errorProvider.SetError(c,"ЕГН трябва да съдържа точно 10 числа!");
        }

        public void validateDot(Control c, char data)
        {
            int hasDot = 0; 
            foreach(char characher in c.Text.ToCharArray())
            {
                if (characher == ',') hasDot++;
                if(hasDot>1) errorProvider.SetError(c,"Некоректно използване на , !");
            }
        }
    }
}
