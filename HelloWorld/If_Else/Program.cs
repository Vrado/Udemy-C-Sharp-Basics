using System;

namespace If_Else
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hour = 12;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }
        }
    }
}
