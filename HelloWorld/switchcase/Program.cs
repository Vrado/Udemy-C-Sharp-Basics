using System;

namespace switchcase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var season = Season.Winter;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("Wow It's hot");
                    break;

                default:
                    Console.WriteLine("WTF");
                    break;
            }
        }
    }
}
