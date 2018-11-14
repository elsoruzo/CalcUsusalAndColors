using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
    class FailsInitializationSelector:Control, BinaryOperation
    {
        public override void doActions(string actionOfmainprogram)
        {
            Console.WriteLine("There is a problem,  so an object of a class  " +
                              "\n FailsInitializationSelector is created to take care of it");
            Program.Main();
        }

        public double DoOperatonSumRestMultDiv(double firstNumber, double secondNumber)
        {
            Console.WriteLine("There is a problem with your operator,  " +
                              "\n the one that goes in between: " + firstNumber +"and"+ secondNumber+" " +
                              "\n Your entery has to be one of these signs ==>  (*, /, +,-)");
            doActions("");
            return 0;
        }
    }
}
