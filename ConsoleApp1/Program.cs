
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("det her et mit program ");
            Console.WriteLine();

            Console.WriteLine("Yo Yo what's up");

            AwesomeClass3 ac1 = new AwesomeClass3("wow", 9880, false);
            Console.WriteLine(ac1.ToString());

            FredrikClass fc = new FredrikClass("Fredrik","Vej 123", 123);
            Console.WriteLine(fc.ToString());


            Mikkel mikkel = new Mikkel("Mikkel", "brand 20", 847475);
        }
    }
}