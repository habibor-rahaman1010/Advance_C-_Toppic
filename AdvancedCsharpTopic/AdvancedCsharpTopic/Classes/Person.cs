using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharpTopic.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, i am {1}", to, this.Name);
        }

        public static Person Parse(int id, string name, string email, string address)
        {
            Person person = new Person();
            person.Id = id;
            person.Name = name;
            person.Email = email;
            person.Address = address;
            return person;
        }
    }
}
