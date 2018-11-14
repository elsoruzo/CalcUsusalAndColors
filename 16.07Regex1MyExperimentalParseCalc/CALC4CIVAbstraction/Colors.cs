using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC4CIVAbstraction
{
   public  class Colors
    {
        public string[] primaryCoulours;
        public string[] secondaryCoulors;

        public string redPrimary = "red";
        public string bluePrimary = "blue";
        public string yellowPrimary = "yellow";

        public string orangeSecondary = "orange";
        public string greenSecondary = "green";
        public string purpleSecondary = "purple";
       // public delegate void Action<T>(T obj);

        public void Meth(string chOp, string choosedColor1, string choosedColor2)
        {
            Action<string, string, string, string, string> op;
            op = Mix;
            Operation(chOp, redPrimary, bluePrimary, yellowPrimary, choosedColor1, choosedColor2, op);
            op = Com;
            Operation(chOp, orangeSecondary, purpleSecondary, greenSecondary, choosedColor1, choosedColor2, op);

            Console.Read();
        }

        public void Operation(string chooseOp, string col1, string col2, string col3, string chcol1, string chcol2, Action<string, string, string, string, string> op)
        {
            if (chooseOp == "mix")
                op(col1, col2, col3, chcol1, chcol2);
            if (chooseOp == "com")
                op(col1, col2, col3, chcol1, chcol2); 
        }
        public void Mix(string col1, string col2, string col3, string chcolor1, string chcolor2)
        {
            if (chcolor1 == chcolor2) { Console.WriteLine("enter diferent colors"); }

            if ((chcolor1==col1|| chcolor2== col1) && (chcolor1 == col2 || chcolor2 == col2))
            {
                Console.WriteLine(purpleSecondary);
            }
            if ((chcolor1 == col2 || chcolor2 == col2) && (chcolor1 == col3 || chcolor2 == col3))
            {
                Console.WriteLine(greenSecondary);
            }
            if ((chcolor1 == col3 || chcolor2 == col3) && (chcolor1 == col1 || chcolor2 == col1))
            {
                Console.WriteLine(orangeSecondary);
            }
        }
        public void Com(string col1, string col2, string col3, string chcolor1, string chcolor2)
        {
            if (chcolor1 == chcolor2) { Console.WriteLine("enter diferent colors"); }

            if ((chcolor1 == col1 || chcolor2 == col1) && (chcolor1 == col2 || chcolor2 == col2))
            {
                Console.WriteLine(redPrimary);
            }
            if ((chcolor1 == col2 || chcolor2 == col2) && (chcolor1 == col3 || chcolor2 == col3))
            {
                Console.WriteLine(bluePrimary);
            }
            if ((chcolor1 == col3 || chcolor2 == col3) && (chcolor1 == col1 || chcolor2 == col1))
            {
                Console.WriteLine(yellowPrimary);
            }
        }
    }
}
