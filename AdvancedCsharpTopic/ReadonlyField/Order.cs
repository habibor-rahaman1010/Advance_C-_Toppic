using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyField
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Location { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;

        public Order()
        {
        }
        public Order(int id) : this()
        {
            this.OrderId = id;
        }

        public Order(int id, string location, string customerName) : this(id)
        {
            this.Location = location;
            this.CustomerName = customerName;
        }
    }
}
