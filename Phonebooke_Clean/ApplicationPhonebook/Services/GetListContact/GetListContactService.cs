using ApplicationPhonebook.DataBase;

namespace ApplicationPhonebook.Services.GetListContact
{
    public class GetListContactService : IGetListContactService
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetListContactService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public List<ContactListDto> Execute()
        {
            var Contact = dataBaseContext.Contacts.Select(p => new ContactListDto()
            {
                FullName = $"{p.Name} {p.LastName}",
                PhoneNumber = p.PhoneNumber,
                Id = p.Id,
            }).ToList();
            return Contact;
        }
    }
}
