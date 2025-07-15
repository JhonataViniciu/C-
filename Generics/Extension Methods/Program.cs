using System;

namespace Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 7, 15, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
