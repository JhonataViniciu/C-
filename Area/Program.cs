using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area.Entities;
using Area.Entities.Enums;
using System.Globalization;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number os shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle of Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), (Console.ReadLine()));
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height1: ");
                    double height = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
                foreach (Shape shape in list)
                {
                    Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
