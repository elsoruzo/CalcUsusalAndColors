using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CALC4CIVAbstraction.Tests
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void MultiplicationCalculation()
        {
            double firstArgument = 5;
            double secondArgument = 10;
            double expexctedResult = 50;
            // act
            Multiplication secondInstanceofMultiplicationClass = new Multiplication();
            double actualValueTheMethodReturns =
                secondInstanceofMultiplicationClass.DoOperatonSumRestMultDiv(firstArgument, secondArgument);
            // assert
            Assert.AreEqual(expexctedResult, actualValueTheMethodReturns);
        }
    }
}
