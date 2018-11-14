using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CALC4CIVAbstraction;

namespace CALC4CIVAbstraction
{
    public class IntroData : Control
    {
        public override void DoActions(string actionOfmainprogram)
        {
            if (actionOfmainprogram == "done")
            { Environment.Exit(0);}
            else if (actionOfmainprogram == "Problems with regex, go to method Main")
            {
                Program.Main();
            }
            else if (actionOfmainprogram == "")
            {
                Program.Main();
            }
            else if (actionOfmainprogram == "Start over again, go to method Main")
            {
                Program.Main();
            }
            else
            {
                EnterFirstOperand(actionOfmainprogram);
            }

        }
        public double FirstArgument = 0;
        public string OperatorString = "";
        public double SecondArgument = 0;
       
        public void EnterFirstOperand(string input)
        {
            CultureInfo culture = new CultureInfo("ru-RU");

            Match firstMatch =
                Regex.Match(input, @"([-+]?[0-9]*[\,]*[\.]?[0-9]+)[ ]*?([+-\/\*])[ ]*?([-+]?[0-9]*[\,]*[\.]?[0-9]+)");

            if (!firstMatch.Success)
            {
                Console.WriteLine("Something went wrong with the REGEX itself.");
                Console.ReadKey();
                DoActions("Problems with regex, go to method Main");
                return;
            }

            Console.WriteLine(firstMatch.Groups[0].Value);
            Console.ReadKey();
            try
            {
            FirstArgument = double.Parse(firstMatch.Groups[1]./*Value*/ToString().Replace('.', ','), culture);
             } catch (Exception e)
            {
                
                Console.WriteLine($"firstArgument{FirstArgument} went wrong. {e}");
                Console.ReadKey();
                DoActions("Problems with regex, go to method Main");
                //return;
            }
            try
            {
                OperatorString = firstMatch.Groups[2].Value;
            }
            catch (Exception e)
            {

                Console.WriteLine($"operatorString{OperatorString} went wrong. {e}");
                Console.ReadKey();
                DoActions("Problems with regex, go to method Main");
                //return;
            }
            try
            {
                SecondArgument = Convert.ToDouble/*double.Parse*/(firstMatch.Groups[3].Value.Replace('.', ','), culture);
            }
            catch (Exception e)
            {

                Console.WriteLine($"secondArgument{SecondArgument} went wrong. {e}");
                Console.ReadKey();
                DoActions("Problems with regex, go to method Main");
                //return;
            }

            if (SecondArgument==0 && OperatorString == "/")
            {
                Console.WriteLine("You cannot divide a number by a zero");
                Console.ReadKey();
                DoActions("Start over again, go to method Main");
                
            }
            else if (FirstArgument == 0 && OperatorString == "/") {
                Console.WriteLine("You cannot divide zero by a number");
                Console.ReadKey();
                DoActions("Start over again, go to method Main");
            }
        }
    }
}
