using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            bool[] YesOrNo = new bool[3];
            nums[2] = 36;

            YesOrNo[1] = true;

            Console.WriteLine($"Tretoto chisl v masiva e {nums[2]}");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Vuvedi {i + 1} chislo");
                nums[i] = int.Parse(Console.ReadLine());
            }
        
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i + 1} chislo v maisva e {nums[i]}");
            }
        }
    }
}
