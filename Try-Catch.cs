using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int res = n1 / n2;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException) //Tratamento
            {
                Console.WriteLine("Division by zero is not allowed ");
            }
            catch (FormatException e) //Tratamento de formatacao
            {
                {
                    Console.WriteLine("Format Error " + e.Message);
                }
            }
        }
    }
}
