using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCasting
{
    public class Student : Person
    {
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public Student() { }

        public Student(int id, string name, int age, DateTime birthDay, string email, string gender) : base(id, name, age, birthDay)
        {
            this.Email = email;
            this.Gender = gender;
        }
    }
}
