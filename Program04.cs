﻿using System;

namespace Program04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            int c = ++b;
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
