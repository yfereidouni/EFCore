namespace EFCore.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public Person Person { get; set; }
    }
}
