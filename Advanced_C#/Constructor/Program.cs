using System;

namespace Constructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car("ERE271827", "Calofonia", 42238983, "BMW", "Good car", "Patrol");

            Console.WriteLine(car.Resistration);
            Console.WriteLine(car.EngineType);
            Console.WriteLine(car.Origine);
        }
    }
}
