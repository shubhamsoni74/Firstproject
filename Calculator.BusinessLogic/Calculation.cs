using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BusinessLogic
{
    public class Calculation
    {
       public int Add(int num01, int num02)
        {
            return num01 + num02;
        }
        public int Subtract(int num01, int num02)
        {
            return num01 - num02;
        }
        public int Multiply(int num01, int num02)
        {
            return num01 * num02;
        }
        public int Divide(int num01, int num02)
        {
            return num01 / num02;
        }


    }
}
