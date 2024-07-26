using AdvancedCsharpTopic.Classes;

namespace AdvancedCsharpTopic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = "Habibor Rhaman";
            person.Email = "habibor.rahaman1010@gmail.com";
            person.Address = "Dhaka";

            person.Introduce("Mosh");

            Person person2 =  Person.Parse(2, "Mosh Hamadani", "mosh12@gmail.com", "Australia");
            person2.Introduce("Habibor Rahaman");
        }
    }
}
