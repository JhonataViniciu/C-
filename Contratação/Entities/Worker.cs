using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.cs.Entities.Enum;
using System.Collections.Generic;

namespace Program.cs.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel  Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContracts> Contracts { get; set; } = new List<HourContracts>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContracts(HourContracts contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracts(HourContracts contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContracts contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
