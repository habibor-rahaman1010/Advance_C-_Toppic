namespace DemoLib
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name) 
        {
            this.Name = name;
        }

        public Product(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public void PrintObject()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }

        public double GetDiscount(int parcentage)
        {
            return (this.Price * parcentage / 100);
        }
    }
}
