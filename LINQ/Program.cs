using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Especificar o data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Define a expressao query
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executar a consulta
            foreach ( int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
