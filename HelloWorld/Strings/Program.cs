using System;
using System.Net.Http.Headers;

namespace Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "Smith";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);
            Console.WriteLine(myFullName);
           
            //verbatim strings
            var text = @"Hi John 
Look into following Path C:\Users\Docs";
            Console.WriteLine(text);
        }

    }
}
