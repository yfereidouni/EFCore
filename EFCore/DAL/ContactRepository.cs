using EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DAL
{
    public class ContactRepository : IContactRepository
    {
        private readonly EFCoreDB efCoreDB = new EFCoreDB();

        public void Delete(Contact contact)
        {
            efCoreDB.Contacts.Remove(contact);
        }

        public Contact Find(int id)
        {
            return efCoreDB.Contacts.Find(id);
        }

        public List<Contact> GetAll()
        {
            return efCoreDB.Contacts.ToList();
        }

        public void Insert(Contact contact)
        {
            efCoreDB.Contacts.Add(contact);
        }

        public void Update(Contact contact)
        {
            efCoreDB.Contacts.Update(contact);
        }
    }
}
