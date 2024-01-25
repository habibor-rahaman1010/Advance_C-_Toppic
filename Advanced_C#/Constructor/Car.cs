using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Car : Vehicle
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? EngineType { get; set; }

        public Car()
        {
            Console.WriteLine("Car is being initialised...");
        }

        public Car(string resistration, string origin, int id, string name, string discription, string enginType) : base(resistration, origin)
        {
            this.Id = id;
            this.Name = name;
            this.Description = discription;
            this.EngineType = enginType;
        }
    }
}
