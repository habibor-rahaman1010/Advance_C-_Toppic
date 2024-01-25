using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 1000f)
            {
                return order.TotalPrice * 0.02f;
            }
            return order.TotalPrice * 0.01f;
        }
    }
}
