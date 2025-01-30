using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //Criacao de uma lista

            list.Add("Maria");  //Adiciona um elemento a lista
            list.Add("Alex");
            list.Add("Joao");
            list.Add("Ana");
            list.Insert(2, "Samanta");  //Inserção de um elemento dentro da lista


            foreach (string obj in list)  //Tamanho da lista
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("List count: " + list.Count);    


            string s1 = list.Find(x => x[0] == 'A');          //Busca pela primeira posição 
                Console.WriteLine("First 'A': " + s1);        //de elemento em uma lista
             

            string s2 = list.FindLast(x => x[0] == 'A');      //Busca pela ultima posição
            Console.WriteLine("Last 'A': " + s2);             //de elemento em uma lista


            int pos1 = list.FindIndex(x => x[0] == 'A');      //Encontrar a primeira posição
            Console.WriteLine("First position 'A': " + pos1); //na lista


            int pos2 = list.FindLastIndex(x => x[0] == 'A');  //Encontrar a ultima posição
            Console.WriteLine("First position 'A': " + pos2); //na lista



            List<string> list2 = list.FindAll(x => x.Length == 5);  //Mostra todos os elementos
            Console.WriteLine("-----------------------");           //que tenham um certo numero
            foreach(string obj in list2)                            //de letras
            {
                Console.WriteLine(obj);
            }


            list.Remove("Alex");                             //Remove um certo elemento da lista
            Console.WriteLine("-----------------------");
            foreach (string obj in list)                            
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'A');               //Remove todos os elementos
            Console.WriteLine("-----------------------");   //que iniciem com a letra 'A'
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveAt(2);                             //Remove o elemento na posição escolhida
            Console.WriteLine("-----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveRange(2, 2);                             //
            Console.WriteLine("-----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
