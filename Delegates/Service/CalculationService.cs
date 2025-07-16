using System;
using System.Collections.Generic;

namespace Delegates.Services
{
    internal class CalculationService
    {
        public static double Max(double x, double y)   //Retonar o maior deles
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)   //Retorna a soma deles
        {
            return x + y;
        }

        public static double Square(double x)          //Retorna o Quadrado dele
        {
            return x * x;
        }
    }
}
