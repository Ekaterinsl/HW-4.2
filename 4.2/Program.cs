using System;

namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            Console.WriteLine("Введите длину последовательности");
            int n = int.Parse(Console.ReadLine());

            int[] numbs = new int[n];
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.WriteLine("Введите число");
                numbs[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbs.Length; i++)
            {
                if (min > numbs[i])
                {
                    min = numbs[i];
                  
                }
                
            }
            Console.WriteLine($"Минимальное число {min} ");

            Console.ReadKey();
        }
    }
}
