using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting
{
    public class Person
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public DateTime? BirthDay { get; set; }

        public Person() { }

        public Person(int id, string name, int age, DateTime birthDay)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BirthDay = birthDay;
        }
    }
}
