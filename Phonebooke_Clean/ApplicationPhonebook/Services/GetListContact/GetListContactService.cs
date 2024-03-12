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
        public List<ContactListDto> Execute(string SearchKey = null)
        {
            var ContactQuery = dataBaseContext.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                    p.Name.Contains(SearchKey)
                    ||
                    p.LastName.Contains(SearchKey)
                    ||
                    p.PhoneNumber.Contains(SearchKey)
                    ||
                    p.Company.Contains(SearchKey)
                    );
            }

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
