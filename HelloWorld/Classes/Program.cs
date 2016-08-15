namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var maggie = new Person();
            maggie.FirstName = "Maggie";
            maggie.LastName = "Tanner";
            maggie.Introduce();
        }
    }
}


