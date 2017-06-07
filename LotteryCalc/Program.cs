using System;

namespace LotteryCalc
{
    static class Program
    {
        private const int NumberOfTickets = 1000;
        private const int NumberOfLotteries = 1000;

        private const int MinimumNumberOfWins = 3;

        private const int NumberOfSimulations = 10000000;

        private static int _resultWin;

        private const int PrintResultEvery = 100000;

        private static readonly Random Rand1 = new Random(319865673);
        private static readonly Random Rand2 = new Random(132456234);

        private static void Main()
        {
            for (int i = 1; i <= NumberOfSimulations; i++)
            {
                int wincounter = 0;

                for (int j = 0; j < NumberOfLotteries; j++)
                {
                    if (Rand1.Next(1, NumberOfTickets) == Rand2.Next(1, NumberOfTickets)) { wincounter++; }
                }

                if (wincounter >= MinimumNumberOfWins) { _resultWin++; }

                if (i % PrintResultEvery == 0) { Console.WriteLine("Result after " + i + " runs: " + (float) _resultWin / i); }
            }

            Console.WriteLine("Final result: " + (double) NumberOfSimulations / _resultWin);
        }
    }
}
