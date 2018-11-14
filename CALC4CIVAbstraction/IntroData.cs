using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
    public class IntroData : Control
    {
        public override void doActions(string actionOfmainprogram)
        {
            if (actionOfmainprogram == "done")
                Environment.Exit(0);
            //else if (actionOfmainprogram == "r")
            //{
            //    Console.WriteLine(Console.ReadLine());
            //}
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
        public double firstArgument = 0;
        public string operatorString = "";
        public double secondArgument = 0;
       
        public void EnterFirstOperand(string input)
        {
            //if (number.match(/^ -{ 0,1}\d +$/)){
            //    //valid integer (positive or negative)
            //    return String(Number.parseInt(number));
            //}else if (number.match(/^\d +\.\d +$/))
            //{
            //    //valid float
            //    return String(Number.parseFloat(number));
            //}
            //else if (number.match(/^\d +\,\d +$/))
            //{
            //    //valid float
            //    return String(Number.parseFloat(number.replace(",", "."))).replace(".", ",");
            //}
            //else
            //{
            //    alert("please enter a number and do not be such Vasia");
            //    //not valid number
            //}
            CultureInfo culture = new CultureInfo("ru-RU");

            Match firstMatch =
                Regex.Match(input, @"([-+]?[0-9]*[\,]*[\.]?[0-9]+)[ ]*?([+-\/\*])[ ]*?([-+]?[0-9]*[\,]*[\.]?[0-9]+)");

            if (!firstMatch.Success)
            {
                Console.WriteLine("Something went wrong with the REGEX itself.");
                Console.ReadKey();
                doActions("Problems with regex, go to method Main");
                return;
            }

            Console.WriteLine(firstMatch.Groups[0].Value);
            Console.ReadKey();
            try
            {
            firstArgument = double.Parse(firstMatch.Groups[1]./*Value*/ToString().Replace('.', ','), culture);
             } catch (Exception e)
            {
                
                Console.WriteLine($"firstArgument{firstArgument} went wrong. {e}");
                Console.ReadKey();
                doActions("Problems with regex, go to method Main");
                //return;
            }
            try
            {
                operatorString = firstMatch.Groups[2].Value;
            }
            catch (Exception e)
            {

                Console.WriteLine($"operatorString{operatorString} went wrong. {e}");
                Console.ReadKey();
                doActions("Problems with regex, go to method Main");
                //return;
            }
            try
            {
                secondArgument = Convert.ToDouble/*double.Parse*/(firstMatch.Groups[3].Value.Replace('.', ','), culture);
            }
            catch (Exception e)
            {

                Console.WriteLine($"secondArgument{secondArgument} went wrong. {e}");
                Console.ReadKey();
                doActions("Problems with regex, go to method Main");
                //return;
            }

            if (secondArgument==0 && operatorString == "/")
            {
                Console.WriteLine("You cannot divide a number by a zero");
                Console.ReadKey();
                doActions("Start over again, go to method Main");
                
            }
            else if (firstArgument == 0 && operatorString == "/") {
                Console.WriteLine("You cannot divide zero by a number");
                Console.ReadKey();
                doActions("Start over again, go to method Main");
            }
           
            // the main valid regex: @"([-+]?[0-9]*[\,]*[\.]?[0-9]+)[ ]*?([+-\/\*])[ ]*?([-+]?[0-9]*[\,]*[\.]?[0-9]+)"
            /*(^[-+]?[0-9]*\\.?[0-9]*.)([+][-][*][/])(^[-+]?[0-9]*\\.?[0-9]*.)*/
            // !!!!Egor verion(.*[+])(.*[0 - 9])
            //last working regex ([-+]?[0-9]*\\.?[0-9]+)([+-\\/\\*])(.*[-+]?[0-9]*\\.?[0-9]+)
            // myworkin with decimals wersion, use comma!  ([-+]?[0-9]*\\,?[0-9]+)([+-\\/\\*])(.*[-+]?[0-9]*\\,?[0-9]+)
            // "" same  onlu better ([-+]?[0-9]*\\,?[0-9]+)[ ]*?([+-\\/\\*])[ ]*?([-+]?[0-9]*\\,?[0-9]+)
            //else
            //{
            //    Match firstMatch1 = Regex.Match(input, "/^ -{ 0,1}\\d +$/");
            //    firstArgument = Convert.ToDecimal(firstMatch1.Value);
            //    return firstArgument;
            //}

        }

        //public string EnterOperator(string input)
        //{
        //    string operatorString = Regex.Match(input, "\\D+").Value;
        //    return operatorString;
        //}

        //public double EnterSecondOperand(string input)
        //{
        //    Match secondMatch = Regex.Match(input, "\\d+$");
        //    double secondArgument = Convert.ToDouble(secondMatch.Value);
        //    return secondArgument;
        //}
    }
}
