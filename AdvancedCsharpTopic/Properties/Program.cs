namespace Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person(new DateTime(1999, 03, 01));
            Console.WriteLine($"Person Age: {person.Age}");
        }
    }
}
