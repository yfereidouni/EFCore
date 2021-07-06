using EFCore.DAL;
using EFCore.Entities;
using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD_Without_Interface_Implementation();
            //CRUD_With_Interface_Implementation();


            //PersonRepository personRepository = new PersonRepository();
            //Person yasser = new Person()
            //{
            //    FirstName = "Farid",
            //    LastName = "Zafarheidari",
            //};
            //yasser.Contacts.Add(new Contact()
            //{
            //    PhoneNumber = "09124545900"
            //});
            //personRepository.Insert(yasser);


            PersonRepository personRepository = new PersonRepository();
            var data1 = personRepository.GetAll();
            foreach (var item in data1)
            {
                Console.Write($"{item.FirstName} {item.LastName}");
                Console.WriteLine(item.PersonId);
            }
        }

        #region CRUD_With_Interface_Implementation
        private static void CRUD_With_Interface_Implementation()
        {
            PersonRepository personRepository = new PersonRepository();

            //Create -----------------------------------------------------------
            Person yasser = new Person()
            {
                FirstName = "Pejman",
                LastName = "Jamshidi"
            };
            yasser.Contacts.Add(new Contact()
            {
                PhoneNumber = "09112323456"
            });
            personRepository.Insert(yasser);
            //------------------------------------------------------------------
            //Update -----------------------------------------------------------
            Person AlirezaTavakoli = personRepository.Find(5);
            AlirezaTavakoli.LastName = "Tavakoli ASL";
            personRepository.Update(AlirezaTavakoli);
            //------------------------------------------------------------------
            Person MajidRezaei = personRepository.Find(11);
            personRepository.Delete(MajidRezaei);
            //------------------------------------------------------------------
            var personList = personRepository.GetAll();
            foreach (var item in personList)
            {
                Console.WriteLine($"Name : {item.FirstName} | {item.LastName} ");
            }
        }
        #endregion

        #region CRUD_Without_Interface_Implementation
        private static void CRUD_Without_Interface_Implementation()
        {
            using (var ctx = new EFCoreDB())
            {
                Person person = new Person
                {
                    FirstName = "Reza",
                    LastName = "Salehi",
                };
                person.Contacts.Add(new Contact()
                {
                    PhoneNumber = "0912653452"
                });

                //var finedPerson = ctx.People.Find(1);
                //finedPerson.FirstName = "AAA";

                //ctx.People.Add(person);
                ctx.SaveChanges();

                //List of Person ----------------------------------
                var people = ctx.People.Where(c => c.FirstName.Contains("Y")).ToList();
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.FirstName} | {item.LastName}");
                }
            }
        }
        #endregion
    }
}
