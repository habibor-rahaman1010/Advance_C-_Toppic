using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverload
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Order> orders { get; set; }

        public Customer()
        {
            this.orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public Customer(int id, string name, string email) : this(id, name)
        {
            this.Email = email;
        }

        public Customer(int id, string name, string email, string address) : this(id, name, email)
        {
           this.Address = address; 
        }
    }
}