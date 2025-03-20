using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Inferencia_de_Tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string orig = " acbd EFGHI ABC abc ";

            string s1 = orig.ToUpper();
            string s2 = orig.ToLower();
            string s3 = orig.Trim();
            int n1 = orig.IndexOf("cb");
            int n2 = orig.LastIndexOf("cb");
            string s4 = orig.Substring(3);
            string s5 = orig.Substring(3, 5);
            string s6 = orig.Replace("a", "x");
            string s7 = orig.Replace("abc", "x");
            bool b1 = String.IsNullOrEmpty(orig);
            bool b2 = String.IsNullOrWhiteSpace(orig);

            Console.WriteLine("Original: -" + orig + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('cb'): -" +  n1+ "-");
            Console.WriteLine("LastIndexOf('cb'): -" + n2 + "-");
            Console.WriteLine("SubString: -" + s4 + "-");
            Console.WriteLine("SubString: -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'x'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpyt: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");




        }
    }
}
