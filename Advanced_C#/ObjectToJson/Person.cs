/*using System;

namespace ObjectToJson
{

    public class Person
    {
        public int PersonId { get; set; }
        public string? PersonName { get; set; }
        public string? Description { get; set; }
        public int Weight { get; set; }
        public string? PersonCategory { get; set; }
        public Address Address { get; set; }
        public List<Contact> Contacts { get; set; }
        public DateTime? Created { get; set; }

        public Person(int personId, string personName, string description, int weight, string personCategory, Address address, List<Contact> contacts, DateTime? created)
        {
            this.PersonId = personId;
            this.PersonName = personName;
            this.Description = description;
            this.Weight = weight;
            this.PersonCategory = personCategory;
            this.Address = address;
            this.Contacts = contacts;
            this.Created = created;
        }
    }
}

public class Address
{
    public string? City { get; set; }
    public string? StreetAddress { get; set; }
    public string? State { get; set; }
    public List<string>? ZipCode { get; set;}
}

public class Contact
{
    public string? Phone { get; set; }
    public string? Email { get; set; }
}*/