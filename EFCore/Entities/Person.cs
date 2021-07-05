using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    //[Table("tbl_People",Schema ="dbo")]
    public class Person
    {
        public int PersonId { get; set; }
        //[MaxLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
