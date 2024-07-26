using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyField
{
    public class Customer
    {
        public int ID { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public readonly List<Order> Orders = new List<Order>();

        public Customer() 
        {
        }

        public Customer(int id, string name, string address) : this() 
        { 
            this.ID = id;
            this.Name = name;
            this.Address = address;
        }

        public Customer(int iD, string name, string address, string phone, string email) : this(iD, name, address)
        {
            Phone = phone;
            Email = email;
        }
    }
}
