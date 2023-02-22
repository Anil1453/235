using System;

namespace foreac

{
    internal class Program
{
    static void Main(string[] args)
    {
        string message = "1234spiashata#$Q%& krastavica";

        char symbol = '&';

        int result = (int)message[4];
        Console.WriteLine($"Letter 2*(is {(char)('(' + '(')} letter from");

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i] + " ; ");
        }

        foreach (char letter in message)
        {
            Console.WriteLine(letter + " - " + (int)letter);
        }
    }
}
}
