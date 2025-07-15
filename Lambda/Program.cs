using System;
namespace Lambda
{
    internal class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)  //Percorre o vetor
            {
                if (numbers[i] % 2 != 0)              //Se o valor for impar
                {
                    numbers[i] += globalValue;        //atribui o valor + o valor global
                }
            }
        }
    }
}
