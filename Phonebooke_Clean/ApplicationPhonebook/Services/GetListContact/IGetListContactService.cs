﻿namespace ApplicationPhonebook.Services.GetListContact
{
    public interface IGetListContactService
    {
        List<ContactListDto> Execute(string searchKey = null);
    }
}
