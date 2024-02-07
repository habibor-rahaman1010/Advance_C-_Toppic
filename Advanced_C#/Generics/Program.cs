using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student<string> habib = new Student<string>("42230200694", "Habibor Rahaman", "habibor.rahaman1010@gmail.com", "CSE");
            Student<string> abdullah = new Student<string>("237873231", "Abdullah Sheikh", "abdullah278@gmail.com", "CSE");
            Teacher<int, string> jalal = new Teacher<int, string>(73878212, "Jalal Uddin", "jalaluddin121@gmail.com", 145790);

            AllPersons allPersons = new AllPersons();
            allPersons.AddPerson(habib);
            allPersons.AddPerson(abdullah);
            allPersons.AddPerson(jalal);

            allPersons.PrintAllPersons();
        }
    }
}
