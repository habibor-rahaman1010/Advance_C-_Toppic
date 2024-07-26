namespace Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.Math();
            Program.UsePoint();
        }

        public static void Math()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(new int[] { 23, 34, 45, 56 });
            Console.WriteLine("Sum of array: {0}", result);

            int result2 = calculator.AddInfinitNumber(23, 45, 34, 56, 67, 78, 11);
            Console.WriteLine("Sum of infinit number: {0}", result2);
        }

        public static void UsePoint()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
