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
        private readonly EFCoreDB efCoreDB = new EFCoreDB();

        public void Delete(Person person)
        {
            efCoreDB.People.Remove(person);
            efCoreDB.SaveChanges();
        }

        public Person Find(int id)
        {
            return efCoreDB.People.Find(id);
        }

        public List<Person> GetAll()
        {
            return efCoreDB.People.ToList();
        }

        public void Insert(Person person)
        {
            efCoreDB.People.Add(person);
            efCoreDB.SaveChanges();
        }

        public void Update(Person person)
        {
            var updatePerson = efCoreDB.People.Find(person.PersonId);
            
            updatePerson.FirstName = person.FirstName;
            updatePerson.LastName = person.LastName;

            efCoreDB.SaveChanges();
        }
    }
}
