using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionMoreExplore
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        private double Blance { get; set; }

        public Person(int id, string name, string description, int age, string email, string phoneNumber, DateTime birtDay) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Age = age;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.BirthDay = birtDay;
            this.Blance = 67543;
        }

        public void Walking(bool wak)
        {
            throw new NotImplementedException();
        }

        private double GetBlance(decimal x)
        {
            throw new NotImplementedException() ;
        }
        public Person GetInformation(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
