using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Vehicle
    {
        public string? Resistration { get; set; }
        public string? Origine { get; set; }

        public Vehicle()
        {
            Console.WriteLine("Vechle is being initilized... " + this.Resistration);
        }

        public Vehicle(string resistration, string origin)
        {
            this.Resistration = resistration;
            this.Origine = origin;
        }
    }
}
