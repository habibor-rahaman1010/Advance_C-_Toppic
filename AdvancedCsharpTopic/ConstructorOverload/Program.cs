namespace ConstructorOverload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Allen", "allen@gmail.com", "U.S.A");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.Address + "\n");

            Order order = new Order(1, "Apple Macbook Pro M3");
            Order order2 = new Order(2, "Hp Elitbook");
            customer.orders.Add(order);
            customer.orders.Add(order2);

            Console.WriteLine("Number of orders: {0}", customer.orders.Count());

            foreach (var item in customer.orders)
            {
                Console.WriteLine("order id: {0}", item.OrderId);
                Console.WriteLine("product name: {0}", item.ProductName);
            }
        }
    }
}
