using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
    public class InitializationSelector
    {
        public IBinaryOperation<double> GetOperatorReturnsTheObjectOfInitializationForTheArithmathicalCalculation(
        string characterOfTheOperator)
        {
       
            switch (characterOfTheOperator)
            {
                case "+":
                    return  new Sum();
                case "-":
                    return  new Rest();
                case "/":
                    return  new Division();
                case "*":
                    return  new Multiplication();
                default:
                    return  new FailsInitializationSelector<double>();
           }
       }
    }
}
