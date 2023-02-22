using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number");
            int wagoncount = int.Parse(Console.ReadLine());

            int[] peopleinwagon = new int[wagoncount];
            for (int i = 0; i < peopleinwagon.Length; i++)
            {
                peopleinwagon[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < peopleinwagon.Length; i++)
            {
                Console.Write($"{peopleinwagon[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine(peopleinwagon.Sum());





        }
    }
}
