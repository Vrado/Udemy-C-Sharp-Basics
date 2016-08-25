using System;

namespace RandomClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();
            const int pwdlength = 10;
            var buffer = new char[pwdlength];
            for (var i = 0; i < pwdlength; i++)
                buffer[i] = (char) ('a' + random.Next(0, 26));
            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
