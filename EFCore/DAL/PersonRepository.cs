using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DAL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDB personDB = new PersonDB();

        public void Delete(Person person)
        {
            personDB.People.Remove(person);
            personDB.SaveChanges();
        }

        public Person Find(int id)
        {
            return personDB.People.Find(id);
        }

        public List<Person> GetAll()
        {
            return personDB.People.ToList();
        }

        public void Insert(Person person)
        {
            personDB.People.Add(person);
            personDB.SaveChanges();
        }

        public void Update(Person person)
        {
            var updatePerson =  personDB.People.Find(person.PersonId);
            
            updatePerson.FirstName = person.FirstName;
            updatePerson.LastName = person.LastName;

            personDB.SaveChanges();
        }
    }
}
