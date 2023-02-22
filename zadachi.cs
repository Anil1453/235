using System;

namespace zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            string[] row1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] row2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < row2.Length; i++)
            {
                if (row1.Contains(row1[i]))
                {
                    Console.Write(row2[i] +" ");
                }
            }
            Console.WriteLine();
          
       
        }
    }
}
