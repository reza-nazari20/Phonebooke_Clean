using ApplicationPhonebook.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhonebook.Services.AddNewContact
{
    public interface IAddNewContactService
    {
        ResultDto Execute(AddNewContactDto addNewContactDto);
    }
}
