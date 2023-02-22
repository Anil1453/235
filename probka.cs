using System;
using System.Linq;

namespace probka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < number.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
            }

            if (number.Length > 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
