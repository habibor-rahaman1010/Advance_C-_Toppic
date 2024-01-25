using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order) 
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This is order already processed");
            }
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1),
            };

            Console.WriteLine($"Shipping Cost: {order.Shipment.Cost}");
            Console.WriteLine($"Shipping Date: {order.Shipment.ShippingDate}");
        }
    }
}
