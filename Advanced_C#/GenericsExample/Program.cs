using System;

namespace GenericsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator<int> calculator = new Calculator<int>();
            Console.WriteLine($"Sum is: {calculator.Summation(23, 34)}");
            Console.WriteLine($"Devide is: {calculator.Divide(34, 2)}");

            Calculator<double> cal = new Calculator<double>();
            Console.WriteLine($"Sum is: {cal.Summation(23.3, 12.2)}");
            Console.WriteLine($"Devide is: {cal.Divide(24.3, 2.2)}");
        }
    }
}
