using ApplicationPhonebook.DataBase;
using ApplicationPhonebook.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhonebook.Services.DeleteContact
{
    public interface IDeleteContactService
    {
        ResultDto Execute(int ContactId);
    }

    public class DeleteContactService : IDeleteContactService
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteContactService(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public ResultDto Execute(int ContactId)
        {
            var Contact = dataBaseContext.Contacts.Find(ContactId);
            if (Contact != null)
            {
                dataBaseContext.Contacts.Remove(Contact);
                dataBaseContext.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess=true,
                    Message="مخاطب با موفقیت حذف شد",
                };
            }
            return new ResultDto()
            {
                IsSuccess=false,
                Message="مخاطب حذف نشد",
            };
        }
    }
}
