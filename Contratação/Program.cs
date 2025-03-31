using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Program.cs.Entities.Enum;
using System.Threading.Tasks;
using Program.cs.Entities;
namespace Program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel),(Console.ReadLine()));
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContracts contract = new HourContracts(date, valuePerHour, hours);
                worker.AddContracts(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.Write("Name: "+ worker.Name);
            Console.Write("Departament"+ worker.Departament.Name);
            Console.Write("Income For: "+ monthAndYear + ": " + worker.Income(year,month).ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
