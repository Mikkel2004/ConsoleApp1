
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

            FredrikClass fredrikClass = new FredrikClass("Fredrik", 123);

            AwesomeClass3 ac2 = new AwesomeClass3("wow2", 9881, true);
            Console.WriteLine(ac2.ToString());
        }
    }
}