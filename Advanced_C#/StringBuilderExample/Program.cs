using System;
using System.Reflection;
using System.Text;

namespace StringBuilderExample
{
    public class Program
    {
        /*  public class Person
          {
              public int Id { get; set; }
              public string? Name { get; set; }
              public int Age { get; set; }
              public DateTime Birthday { get; set;}
              public string? Email { get; set;}
              public string[]? Contacts { get; set;}
              public int[]? Ids { get; set;}
              public Address Address { get; set;}
          }

          public class Address
          {
              public string Country { get; set; }
              public string City { get; set; }
              public int PostalCode { get; set; }
              public string CountryCode { get; set; }
              public int ZipCode { get; set; }
          }*/


        public class Course
        {
            public string Title { get; set; }
            public Instructor Teacher { get; set; }
            public List<Topic> Topics { get; set; }
            public double Fees { get; set; }
            public List<AdmissionTest> Tests { get; set; }
        }

        public class AdmissionTest
        {
            public DateTime StartDateTime { get; set; }
            public DateTime EndDateTime { get; set; }
            public double TestFees { get; set; }
        }

        public class Topic
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public List<Session> Sessions { get; set; }
        }

        public class Session
        {
            public int DurationInHour { get; set; }
            public string LearningObjective { get; set; }
        }

        public class Instructor
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public Address PresentAddress { get; set; }
            public Address PermanentAddress { get; set; }
            public List<Phone> PhoneNumbers { get; set; }
        }

        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string[] ZipCode { get; set; }
            public int[] PostalCode { get; set; }
            public Country[] Countries { get; set; }
        }

        public class Phone
        {
            public string Number { get; set; }
            public string Extension { get; set; }
            public string CountryCode { get; set; }
        }
        public class Country
        {
            public string Name { get; set; }
            public string CountryCode { get; set; }
            public int[] StateCode { get; set; }
            public string StateName { get; set; }
        }

        public static void Main(string[] args)
        {
            /*var myObj = new Person
            {
                Id = 144369,
                Name = "Habibor Rahaman",
                Age = 24,
                Birthday = DateTime.Today,
                Email = "habibor.rahaman1010@gmail.com",
                Contacts = new string[] { "01768280237", "01311606870" },
                Ids = new int[] { 1232, 3423, 4543, 5634 },
                Address = new Address
                {
                    Country = "Bangladesh",
                    City = "Dhaka",
                    PostalCode = 21897,
                    CountryCode = "BD1971",
                    ZipCode = 1276
                }
            };

            var obj = new { 
                Name = "Labib", 
                Sms = new int[] {5, 6, 7, 8, 9, 10}, 
                Subject = new string[]{"Bnagla", "English"},
            };

*/


            Address presentAddress = new Address
            {
                Street = "123 Main St",
                City = "Cityville",
                Country = "Countryland",
                ZipCode = new string[] { "12345", "54321" },
                PostalCode = new int[] { 123, 456 },
                Countries = new Country[]
               {
                    new Country { Name = "Country1", CountryCode = "CC1", StateName = "State1", StateCode = new int[]{ 1, 2, 3 } },
                    new Country { Name = "Country2", CountryCode = "CC2", StateName = "State2", StateCode = new int[]{ 4, 5, 6 } }
               }
            };

            Address permanentAddress = new Address
            {
                Street = "456 Elm St",
                City = "Villageton",
                Country = "Otherland",
                ZipCode = new string[] { "67890", "09876" },
                PostalCode = new int[] { 789, 654 },
                Countries = new Country[]
                {
                    new Country { Name = "Country3", CountryCode = "CC3", StateName = "State3", StateCode = new int[]{ 7, 8, 9 } },
                    new Country { Name = "Country4", CountryCode = "CC4", StateName = "State4", StateCode = new int[]{ 10, 11, 12 } }
                }
            };

            // Create an instance of Phone
            Phone phone1 = new Phone
            {
                Number = "123-456-7890",
                Extension = "123",
                CountryCode = "+1"
            };

            Phone phone2 = new Phone
            {
                Number = "987-654-3210",
                Extension = "456",
                CountryCode = "+1"
            };

            // Create an instance of Instructor
            Instructor instructor = new Instructor
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                PresentAddress = presentAddress,
                PermanentAddress = permanentAddress,
                PhoneNumbers = new List<Phone> { phone1, phone2 }
            };

            // Create an instance of Session
            Session session1 = new Session
            {
                DurationInHour = 1,
                LearningObjective = "Objective 1"
            };

            Session session2 = new Session
            {
                DurationInHour = 2,
                LearningObjective = "Objective 2"
            };

            // Create an instance of Topic
            Topic topic = new Topic
            {
                Title = "Topic Title",
                Description = "Topic Description",
                Sessions = new List<Session> { session1, session2 }
            };

            // Create an instance of AdmissionTest
            AdmissionTest admissionTest = new AdmissionTest
            {
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddDays(1),
                TestFees = 100.00
            };

            // Create an instance of Course
            Course course = new Course
            {
                Title = "Course Title",
                Teacher = instructor,
                Topics = new List<Topic> { topic },
                Fees = 500.00,
                Tests = new List<AdmissionTest> { admissionTest }
            };

            string jsonData = JsonFormatter.Converter(course);
            Console.WriteLine(jsonData);
        }
    }
}
