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
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);  //instanciando o FileStrem ao arquivo
                sr = new StreamReader(fs); //instanciando o StreamReader ao FileStream
                string line = sr.ReadLine(); //lê a linha do arquivo e armazena na variavel
                Console.WriteLine(line);  //imprime a linha
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}
