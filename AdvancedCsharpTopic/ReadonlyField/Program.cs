namespace ReadonlyField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Habibor Rahaman", "Dhaka", "01768280237", "habibor.rahaman1010@gmail.com");

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine("Number of orders: {0}", customer.Orders.Count());
        }
    }
}
