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
            string sourcePath = @"C:\temp\file1.txt";  //caminho do arquivo principal
            string targetPath = @"C:\temp\file2.txt";  //caminho do arquivo secundario(nao existe ainda)

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); //busca o arquivo principal
                fileInfo.CopyTo(targetPath);      //cria uma copia do arquivo que foi buscado
                string[] lines = File.ReadAllLines(sourcePath); //execula a leitura do arquivo e guarda em um vetor
                foreach(string line in lines)  //faz a varredura do conteudo
                {
                    Console.WriteLine(line); //imprime o conteudo
                }
            }   
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");  //caso o arquivo ja exista no diretorio mostrara o erro
                Console.WriteLine(e.Message);
            }
        }
    }
}
