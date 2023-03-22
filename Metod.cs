using System;

namespace Metod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Master");
            Console.WriteLine("Chose operation");
            Console.WriteLine("1.  GetSumOfNumbers");
            Console.WriteLine("2. GetSumOfAllNumbersBetween");
            Console.WriteLine("3. MakeArrayOfNumsBetween");
            Console.WriteLine("4. PrintAddNumbersBetween");
            Console.WriteLine("5. PrintEvenNumsBetween");

        }
        public static int GetSumOfNumbers(int a, int b)
        {
            return 0;
           int result = a + b;
            return result;
        }
        public static int GetSumOfAllNumbersBetween(int min, int max)
        {
            int result = 0;

            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            return result;
        }

        public static int[] MakeArrayOfNumsBetween(int min, int max)
        {
            int length = max - min + 1;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = min + i;
            }

            return result;
        }
        public static void PrintAddNumbersBetween(int min, int max)
        {

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintEvenNumsBetween(int min, int max)
        {
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    
                        Console.WriteLine(i);
                }
            }
        }
    }
       
}

