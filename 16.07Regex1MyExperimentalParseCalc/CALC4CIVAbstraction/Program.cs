using System;
using System.Diagnostics.Eventing.Reader;

namespace CALC4CIVAbstraction
{
    public class Program 
    {
        public double StoresTheResultOfTheCalculation;

        public static void Main()
        {
            //cration of instanes/ objects
            Console.WriteLine("Please, enter M to acsess binary operation calculator" +
                              " \n or write 'done' to terminate the program" +
                              " \n or write 'C' to use the color calc");
            string choseTHeCalcType = Console.ReadLine();
            if (choseTHeCalcType == "done")
            { Environment.Exit(0);}
            if (choseTHeCalcType == "C")
            {
                Colors color = new Colors();
                color.primaryCoulours = new string[3] {color.redPrimary, color.bluePrimary, color.yellowPrimary};
                color.secondaryCoulors = new string[3]{color.orangeSecondary, color.greenSecondary, color.purpleSecondary};
                // Colors.Action<string> op = null;
                Console.WriteLine("Please, enter mix to mix colors or com to to find the common color colors");
                string whatToDo = Console.ReadLine();
                Console.WriteLine("Please, enter your first color");
                string firstColor = Console.ReadLine();
                Console.WriteLine("Please, enter second color");
                string secondColor = Console.ReadLine();

                color.Meth(whatToDo, firstColor, secondColor);
                Main();
            }
            else if (choseTHeCalcType == "M")
            {
                IntroData introData = new IntroData();
                Result ofResultClass = new Result();
                Console.WriteLine("Please, enter your binary operation, for example: 2+3," +
                                  " \n or write 'done' to terminate the program");
            string consoleInputInitialData = Console.ReadLine();
            introData.DoActions(consoleInputInitialData);

            //introData.EnterFirstOperand(consoleInputInitialData);
            double storesFirstOperand = introData.FirstArgument;
            string storesTheOperator = introData.OperatorString;
            double storesSecondOperand = introData.SecondArgument;

            InitializationSelector initializationSelectorInstance = new InitializationSelector();
            //initializationSelectorInstance.doActions();
            IBinaryOperation<double> storesTheObjectOfInitializationForTheArithmathicalCalculation =
                initializationSelectorInstance
                    .GetOperatorReturnsTheObjectOfInitializationForTheArithmathicalCalculation(storesTheOperator);

            double storesTheResultOfTheCalculation =
                storesTheObjectOfInitializationForTheArithmathicalCalculation.DoOperatonSumRestMultDiv(
                    storesFirstOperand, storesSecondOperand);
            ofResultClass.DisplayAnswer(storesTheOperator, storesFirstOperand, storesSecondOperand,
                storesTheResultOfTheCalculation);

            Main();
            Console.ReadKey();
        }else {
            Main();
        }
    }
       
}


   









}