using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class AllPersons
    {
        private readonly List<IPerson> Persons;

        public AllPersons()
        {
            Persons = new List<IPerson>();
        }

        public void AddPerson(IPerson person)
        {
            this.Persons.Add(person);   
        }
        public void PrintAllPersons()
        {
            foreach(IPerson person in Persons)
            {
                person.DisplayPerson();
            }
        }
    }
}
