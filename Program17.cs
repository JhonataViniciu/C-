﻿using System;
using System.Globalization;

namespace Program17
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+ volume.ToString("F2",CultureInfo.InvariantCulture ));
            Console.WriteLine("Valor de Pi: "+ Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

       

    }
}
