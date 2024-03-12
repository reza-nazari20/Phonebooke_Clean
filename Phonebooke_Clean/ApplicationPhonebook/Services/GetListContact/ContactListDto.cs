namespace ApplicationPhonebook.Services.GetListContact
{
    public class ContactListDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
