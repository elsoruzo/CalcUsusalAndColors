using System;
namespace CALC4CIVAbstraction
{
    public class Program 
    {
        public static double storesTheResultOfTheCalculation;

        public static void Main()
        {
            //cration of instanes/ objects
            
            IntroData introData = new IntroData();
            Result ofResultClass = new Result();
            Console.WriteLine("Please, enter your binary operation, for example: 2+3," +
                              " \n or write 'done' to terminate the program");
            string consoleInputInitialData = Console.ReadLine();
            introData.doActions(consoleInputInitialData);

            //introData.EnterFirstOperand(consoleInputInitialData);
            double storesFirstOperand = introData.firstArgument;
            string storesTheOperator = introData.operatorString;
            double storesSecondOperand = introData.secondArgument;


            InitializationSelector initializationSelectorInstance = new InitializationSelector();
            //initializationSelectorInstance.doActions();
            BinaryOperation storesTheObjectOfInitializationForTheArithmathicalCalculation = 
                initializationSelectorInstance.GetOperatorReturnsTheObjectOfInitializationForTheArithmathicalCalculation(storesTheOperator);

            double storesTheResultOfTheCalculation =
                storesTheObjectOfInitializationForTheArithmathicalCalculation.DoOperatonSumRestMultDiv(
                    storesFirstOperand, storesSecondOperand);
            ofResultClass.DisplayAnswer(storesTheOperator, storesFirstOperand, storesSecondOperand, storesTheResultOfTheCalculation);
            
            introData.doActions(consoleInputInitialData);
            //Console.WriteLine("if you wont to perform calculations starting from the result press r" +
            //                  " \n or write 'done' to terminate the program");
            introData.doActions("Start over again, go to method Main");
            Console.ReadKey();
        }
       
}


   









}