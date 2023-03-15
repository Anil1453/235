using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 7, 8, 9, 0, -12, 43, 24 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] += 1;
                }
                else
                {
                    numbers[i] += 2;
                }
            }

            string output = string.Join(",", numbers);
            Console.WriteLine(output);
        }
    }
}
