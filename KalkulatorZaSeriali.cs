using System;

namespace KalkulatorZaSeriali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameofseries = Console.ReadLine(); //BreakingBAd
            int seasonNumber = int.Parse(Console.ReadLine()); // 5
            int episodeInSason = int.Parse(Console.ReadLine()); // 10
            double timeFor1Episode = double.Parse(Console.ReadLine()); // 42.50

            double additionalFinalEpisodeTime = 10d * seasonNumber;
            double episodeTimeWithCommersials = 1.2 * timeFor1Episode;

            int totalCountOfEpisodes = episodeInSason * seasonNumber;

            double totalTime = additionalFinalEpisodeTime + episodeTimeWithCommersials * totalCountOfEpisodes;

            Console.WriteLine($"Total time needed to watch the {nameofseries} series is {Math.Floor(totalTime)} minute.");

        }
    }
}
