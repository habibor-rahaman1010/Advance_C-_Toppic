using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Teacher<I, T> : IPerson
    {
        public I? TeacherID { get; set; }
        public T? Name { get; set; } 
        public T? Email { get; set; }
        public I? Salary { get; set; }

        public Teacher(I id, T name, T email, I salary) 
        {
            this.TeacherID = id;
            this.Name = name;
            this.Email = email;
            this.Salary = salary;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Teacher ID: {this.TeacherID}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Salary: {this.Salary}");
            Console.WriteLine();
        }
    }
}
