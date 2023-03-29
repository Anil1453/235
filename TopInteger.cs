using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                    bool isGoodNumber= true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (j > i)
                    {
                        Console.WriteLine(j); ;
                    }
                }
            }
        }
    }
}
