using System;

namespace UpCastingDownCasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person student = new Student(144369, "Habib", 24, new DateTime(1999, 3, 5), "habibor.rahaman1010@gmail.com", "Male");
            Person teacher = new Teacher(723694, "Jalal Uddin", 43, new DateTime(1982, 4, 9), 80500, "C# Teacher", "jalauddin@gmail.com");

            Student student1 = (Student) student;
            Teacher teacher1 = (Teacher) teacher;
        }
    }
}
