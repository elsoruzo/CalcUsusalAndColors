using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CALC4CIVAbstraction.Tests
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void DivisionCalculation()
        {    // arrenge
            double firstArgument = 10;
            double secondArgument = 5;
            double expexctedResult = 2;
            // act
            Division secondInstanceofDivisionClass = new Division();
            double actualValueTheMethodReturns =
                secondInstanceofDivisionClass.DoOperatonSumRestMultDiv(firstArgument, secondArgument);
            // assert
            Assert.AreEqual(expexctedResult, actualValueTheMethodReturns);
        }
    }
}
