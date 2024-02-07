using System;
using System.Collections;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace LinqExample
{
    public class Program
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 42230200469, Name = "Habibor Rahaman", Age = 24, Email = "habibor.rahaman1010@gmail.com", Scores = new List<int>(){23, 45, 56, 67} },
            new Student() { Id = 42230200470, Name = "John Doe", Age = 25, Email = "john.doe@example.com", Scores = new List<int>() { 34, 56, 78, 89 } },
            new Student() { Id = 42230200472, Name = "Bob Johnson", Age = 23, Email = "bob.johnson@example.com", Scores = new List<int>() { 56, 78, 90, 93 } },
            new Student() { Id = 42230200473, Name = "Emily Davis", Age = 26, Email = "emily.davis@example.com", Scores = new List<int>() { 67, 89, 91, 95 } },
            new Student() { Id = 42230200474, Name = "Michael Wilson", Age = 24, Email = "michael.wilson@example.com", Scores = new List<int>() { 78, 90, 93, 97 } },
            new Student() { Id = 42230200475, Name = "Sarah Brown", Age = 27, Email = "sarah.brown@example.com", Scores = new List<int>() { 89, 91, 95, 99 } },
            new Student() { Id = 42230200471, Name = "Alice Smith", Age = 22, Email = "alice.smith@example.com", Scores = new List<int>() { 45, 67, 89, 91 } },
            new Student() { Id = 42230200476, Name = "David Taylor", Age = 21, Email = "david.taylor@example.com", Scores = new List<int>() { 90, 93, 97, 100 } },
            new Student() { Id = 42230200477, Name = "Emma Martinez", Age = 28, Email = "emma.martinez@example.com", Scores = new List<int>() { 91, 95, 99, 101 } },
            new Student() { Id = 42230200478, Name = "James Garcia", Age = 20, Email = "james.garcia@example.com", Scores = new List<int>() { 92, 97, 100, 103 } },
        };

        public static void Main(string[] args)
        {
            IEnumerable<Student> studeQuery =
                from student in students
                where student.Scores[0] > 90
                select student;

            IEnumerable<Student> studentAgeSort = from student in Program.students
                                                  where student.Age > 25 select student;

            foreach (Student findStudent in studentAgeSort)
            {
                Console.WriteLine($"Name: {findStudent.Name}");
            }
            Console.WriteLine();

            foreach (Student item in studeQuery)
            {
                Console.WriteLine($"Name: {item.Name}");
            }
            Console.WriteLine();

            IEnumerable<Student> emailQuery = from student in Program.students
                                              where student.Email.Length > 24
                                              select student;

            foreach(Student item in emailQuery)
            {
                Console.WriteLine($"Email: {item.Email}");
            }
            Console.WriteLine();

            //group by query
            IEnumerable<IGrouping<char, Student>> groupQuery = from student in Program.students
                                                               group student by student.Name[0];

            foreach (IGrouping<char, Student> item in groupQuery)
            {
                Console.WriteLine($"{item.Key}");
                foreach (Student item2 in item)
                {
                    Console.WriteLine($"Name: {item2.Name}");
                }
                Console.WriteLine();
            }

            //group by query then order by query

            IOrderedEnumerable<IGrouping<char, Student>> groupQuery2 = from student in Program.students
                                                                       group student by student.Email[0] 
                                                                       into studentGroup orderby studentGroup.Key 
                                                                       select studentGroup;

            foreach (IGrouping<char, Student> item in groupQuery2)
            {
                Console.WriteLine(item.Key);
                foreach (Student item2 in item)
                {
                    Console.WriteLine($"Email {item2.Email}");
                }
                Console.WriteLine();
            }

            IEnumerable<string> studentQuery = from student in Program.students
                                                let totalScore = student.Scores[0] + student.Scores[0] + student.Scores[0]
                                                + student.Scores[0]
                                                where (totalScore / 4) < student.Scores[1]
                                                select student.Name + " | " + student.Email;

            foreach (string studentName in studentQuery)
            {
                Console.WriteLine(studentName);
            }
            Console.WriteLine();
            int averageScore = 70;

            //write a query and return a anonymouse objet
            IEnumerable<object> studentQuery2 = from student in Program.students
                                                let totalScore = student.Scores[0] + student.Scores[0] + student.Scores[0]
                                                + student.Scores[0]
                                                where (totalScore / 4) > averageScore
                                                select new { id = student.Id, score = totalScore };

            foreach (object studentName in studentQuery2)
            {
                Console.WriteLine(studentName);
            }
        }
    }
}
