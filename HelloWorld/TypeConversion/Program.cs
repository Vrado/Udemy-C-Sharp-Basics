using System;

namespace TypeConversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);


            try
            {
                var number = "1234";
                var a = Convert.ToByte(number);
                Console.WriteLine(a);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could nut be converted to a byte!");
                throw;
            }
        }
    }
}
