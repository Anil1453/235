using System;

namespace days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Ponedelnik", "Vtornik", "Srqda", "Chetvurtuk", "Petuk", "Subota", "Nedelq" };
            int Theday = int.Parse(Console.ReadLine());
            if (Theday <= 0 || Theday > 7)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(days[Theday-1]);
            }
        }
    }
}
