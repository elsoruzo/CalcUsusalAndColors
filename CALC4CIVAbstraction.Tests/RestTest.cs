using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CALC4CIVAbstraction.Tests
{
    [TestClass]
    public class RestTest
    {
        [TestMethod]
        public void SubtractionCalculation()
        {
            double firstArgument = 10;
            double secondArgument = 5;
            double expexctedResult = 5;
            // act
            Rest secondInstanceofSubstractionClass = new Rest();
            double actualValueTheMethodReturns =
                secondInstanceofSubstractionClass.DoOperatonSumRestMultDiv(firstArgument, secondArgument);
            // assert
            Assert.AreEqual(expexctedResult, actualValueTheMethodReturns);
        }
    }
}
