﻿using System;
using System.Collections.Generic;
namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How Many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i< n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}
