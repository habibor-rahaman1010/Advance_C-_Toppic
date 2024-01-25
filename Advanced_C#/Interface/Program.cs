using System;

namespace Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator());    
            Order order = new Order() {DatePlaced = DateTime.Now, TotalPrice = 2375f};
            orderProcessor.Process(order);
        }
    }
}
