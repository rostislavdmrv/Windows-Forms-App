using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    internal class Class1
    {
        public double AddNumbers(String buttonValue,double val1, double val2)
        {
            switch (buttonValue)
            {
                case "+":return val1 + val2;
                    break;
                case "-":return val1 - val2;
                    break;
                case "*": return val1 * val2;
                    break;
                case "/": return val1 / val2;
                    break;
                    default: return 0;
            }
        }

    }
}
