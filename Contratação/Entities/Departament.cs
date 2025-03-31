using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Entities
{
    internal class Departament
    {
        public String Name { get; set; }

        public Departament()
        {
        }

        public Departament(String name)
        {
            Name = name;
        }
    }
}
