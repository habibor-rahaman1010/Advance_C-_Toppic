using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting
{
    public class Teacher : Person
    {
        public int Salary { get; set; } = 0;
        public string Designation { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Teacher () { }
        public Teacher(int id, string name, int age, DateTime birthDay, int salary, string desicnation, string email)
            : base(id, name, age, birthDay)
        {
            this.Salary = salary;
            this.Designation = desicnation;
            this.Email = email;
        }
    }
}
