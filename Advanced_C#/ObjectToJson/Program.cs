using System.Text.Json;

namespace ObjectToJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Address address = new Address
             {
                 City = "Dhaka",
                 StreetAddress = "120/2",
                 State = "Costa",
                 ZipCode = new List<string>() { "1234", "2334", "5654", "909" }
             };

             List<Contact> contacts = new List<Contact>()
             {
                 new Contact {Phone = "01768280237", Email = "habibor.rahaman1010@gmail.com"},
                 new Contact {Phone = "01782983274", Email = "habibor.rahaman0101@gmail.com"},
                 new Contact {Phone = "01373287342", Email = "habibor.rahaman@gmail.com"},
             };

              Person person = new Person(101, "Habibor Rahaman", "I am a software engineer!", 67, "Humble and Honest", address, contacts, DateTime.Now);
             /*string serializePerson = JsonSerializer.Serialize(person);
             Console.WriteLine(serializePerson);
             Person? deserialisePerson = JsonSerializer.Deserialize<Person>(serializePerson);
             Console.WriteLine(deserialisePerson);*/

            /* string serializeData = JsonFormatter.Convert(person);
             Console.WriteLine(serializeData);*/


            /* var presentAddress = new Address
             {
                 Street = "123 Main Street",
                 City = "Anytown",
                 Country = "Country",
                 ZipCode = new[] {"y237ew", "h3e67er", "83uw9hy32"},
                 PostalCode = new[] {1234, 2345, 1290}
             };

             var permanentAddress = new Address
             {
                 Street = "456 Second Street",
                 City = "Othertown",
                 Country = "Country"
             };

             // Creating instance of Instructor
             var instructor = new Instructor
             {
                 Name = "John Doe",
                 Email = "john.doe@example.com",
                 PresentAddress = presentAddress,
                 PermanentAddress = permanentAddress,
                 PhoneNumbers = new List<Phone>
                 {
                     new Phone { Number = "123456789", Extension = "123", CountryCode = "+1" },
                     new Phone { Number = "987654321", Extension = "456", CountryCode = "+1" }
                 }
             };

             // Creating instances of Session
             var session1 = new Session
             {
                 DurationInHour = 1,
                 LearningObjective = "Introduction to the course"
             };

             var session2 = new Session
             {
                 DurationInHour = 2,
                 LearningObjective = "Advanced topics"
             };

             // Creating instance of Topic
             var topic = new Topic
             {
                 Title = "Course Introduction",
                 Description = "This topic covers the introduction to the course",
                 Sessions = new List<Session> { session1, session2 }
             };

             // Creating instances of AdmissionTest
             var admissionTest1 = new AdmissionTest
             {
                 StartDateTime = DateTime.Now,
                 EndDateTime = DateTime.Now.AddDays(1),
                 TestFees = 100
             };

             var admissionTest2 = new AdmissionTest
             {
                 StartDateTime = DateTime.Now.AddDays(2),
                 EndDateTime = DateTime.Now.AddDays(3),
                 TestFees = 150
             };

             // Creating instance of Course
             var course = new Course
             {
                 Title = "C# Programming",
                 Teacher = instructor,
                 Topics = new List<Topic> { topic },
                 Fees = 500,
                 Tests = new List<AdmissionTest> { admissionTest1, admissionTest2 }
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

            string json = EditJsonFormatter.Convert(course);
            Console.WriteLine(json);
        }
    }
}
