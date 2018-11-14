using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CALC4CIVAbstraction.Tests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AdditionCalculation()
        {
            // arrenge
            double firstArgument = 5;
            double secondArgument = 10;
            double expexctedResult = 15;
            // act
            Sum secondInstanceofAditionClass = new Sum();
            double actualValueTheMethodReturns =
                secondInstanceofAditionClass.DoOperatonSumRestMultDiv(firstArgument, secondArgument);
            // assert
            Assert.AreEqual(expexctedResult, actualValueTheMethodReturns);
        }
    }
}
