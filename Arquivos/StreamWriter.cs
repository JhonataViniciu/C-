using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace execoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath); //ler o conteudo do arquivo e guardar no vetor

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
