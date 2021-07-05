using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        void Insert(Person person);
        void Delete(Person person);
        void Update(Person person);
        Person Find(int id);
    }
}
