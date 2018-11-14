using System;

namespace CALC4CIVAbstraction
{
    public interface IBinaryOperation<T>
    {
         double DoOperatonSumRestMultDiv(T firstNumber, T secondNumber);
    }
}
