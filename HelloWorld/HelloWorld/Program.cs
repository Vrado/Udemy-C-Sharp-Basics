using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World");

            //Variables
            
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isWorking);
            

            //Format String
            Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);
            


        }
    }
}
