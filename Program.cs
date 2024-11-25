using System;

namespace Program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;    //Ambas devem ser aceitas
            bool c2 = 2 > 3 || 4 != 5;    //Pelo menos uma deve ser aceita
            bool c3 = !(2 > 3) && 4 != 5; 

            Console.WriteLine(c1);  //Flase
            Console.WriteLine(c2);  //True
            Console.WriteLine(c3);  //True

            Console.WriteLine("-----------------");

            bool c4 = 10 < 5;       //False
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c5);
        }
    }
}
