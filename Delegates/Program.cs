using System;
using Delegates.Services;

namespace Delegates
{

    delegate double BinaryNumericOperation(double n1, double n2);  //criando um tipo referencial

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;  //introduzindo a referencia

            double resul = op.Invoke(a, b);
            Console.WriteLine(resul);
        }
    }
}
