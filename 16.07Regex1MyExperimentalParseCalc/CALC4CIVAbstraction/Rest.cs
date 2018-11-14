using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
    public class Rest : IBinaryOperation<double>
    {
        public  double DoOperatonSumRestMultDiv(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
