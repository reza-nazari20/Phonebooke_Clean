using ApplicationPhonebook.DataBase;
using ApplicationPhonebook.Dto;
using DomainPhonebook.Entities;

namespace ApplicationPhonebook.Services.AddNewContact
{
    public class AddNewContactService : IAddNewContactService
    {
        private readonly IDataBaseContext dataBaseContext;
        public AddNewContactService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public ResultDto Execute(AddNewContactDto newcontact)
        {
            if (string.IsNullOrEmpty(newcontact.Phonenumber))
            {
                return new ResultDto()
                {
                    IsSuccess=false,
                    Message="هشدار",
                };
            }

            Contact contact = new Contact(newcontact.Name,newcontact.Lastname,newcontact.Phonenumber,newcontact.Company);

            dataBaseContext.Contacts.Add(contact);
            dataBaseContext.SaveChanges();

            return new ResultDto()
            {
                IsSuccess=true,
                Message="مخطب ذخیره شد"
            };
        }
    }
}
