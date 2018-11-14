using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
    public class Result
    {
        public void DisplayAnswer(string operatorDOp, double firstOperandD, double secondOperandD, double answerD)
        {
            Console.WriteLine($"{firstOperandD} {operatorDOp} {secondOperandD} = {answerD}");
            Console.ReadKey();
        }
    }
}
