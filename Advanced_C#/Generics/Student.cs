using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Generics
{
    public class Student<T> : IPerson
    {
        public T Id { get; set; }
        public T Name { get; set; }
        public T Email { get; set; }
        public T Department { get; set; }

        public Student(T id, T name, T email, T department)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Department = department;

        }
        public void DisplayPerson()
        {
            Console.WriteLine($"ID: {this.Id}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Department: {this.Department}");
            Console.WriteLine();
        }
    }
}
