using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        void Insert(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
        Contact Find(int id);
    }
}