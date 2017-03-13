using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalcBrain
    {
        public double firstOperand;
        public double secondOperand;
        public double result;
        public double SumOperation()
        {
            result = firstOperand + secondOperand;
            return result;
        }
    }
}
