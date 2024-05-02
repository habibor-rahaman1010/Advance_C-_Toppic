using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }  

        public Product(string name, int price) 
        {
            this.Name = name;
            this.Price = price;
        }

        public double CalculateDiscount(double parcentage)
        {
            return (Price * parcentage / 100);
        }
        
        public static string FormateSKU(string prefix)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            return prefix + " " + rand.Next(1, 1000).ToString();
        }
    }
}
