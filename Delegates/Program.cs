using System;
using Delegates.Services;

namespace Delegates
{

    delegate void BinaryNumericOperation(double n1, double n2);  //criando um tipo referencial

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;  //introduzindo a referencia
            op += CalculationService.ShowMax;  //Introducao de mais uma referencia

            op(a, b);
        }
    }
}
