using System;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Purvoslav";
            p1.Age = 16;

            Person p2 = new Person();
            p1.Name = "Vtorislav";
            p1.Age = 30;

            Person p3 = new Person();
            p1.Name = "Tritomir";
            p1.Age = 10;

            p1.Ageup();
            p1.AgeUp();

            Person[] people = { p1, p2, p3 };


        }
        public class Person
        {
            private string EGN = "";
            public string Name { get; set; }
            public int Age { get; set; } = 10;
            
           
        }
        public void AgeUp(int Age)
        {
            Age++; 
            Console.WriteLine($"{Name} aged up and now is {Age} years old!");
        }
        public void PrintMyEGN()
        {
            Console.WriteLine("****"+EGN.Substring(3,4)+"****");    
        }
        public void RecordMyEGN(string egn)
        {
            EGN = egn;
        }
    }
  
}
