using DesignPattern.Signleton;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Logger logger = Logger.Instance;
            Logger logger2 = Logger.Instance;

            if (logger == logger2)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not sanme");
            }
        }
    }
}
