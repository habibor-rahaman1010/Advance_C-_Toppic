using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverload
{
    public class Order
    {
        public int OrderId {  get; set; }
        public string ProductName { get; set; } = string.Empty;

        public Order()
        {
            
        }
        public Order(int id, string productName)
        {
            this.OrderId = id;
            this.ProductName = productName;
        }
    }
}
