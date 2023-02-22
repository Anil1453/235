using System;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 3 words!");
            Console.Write("Input First Word!");
            string word1 = Console.ReadLine();
            Console.Write("Input Second Word!");
            string word2 = Console.ReadLine();
            Console.Write("Input Third Word!");
            string word3 = Console.ReadLine();
            Console.Write("Wich word do you like 1, 2, 3?");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)  
                {
                Console.WriteLine($"Your Word is {word1}");
            }
           if (answer == 2)
            {
                Console.WriteLine($"Your Word is {word2}");
            }
               if (answer == 3)
            {
                Console.WriteLine($"Your Word is {word3}");
            }

            
        }
    }
}
