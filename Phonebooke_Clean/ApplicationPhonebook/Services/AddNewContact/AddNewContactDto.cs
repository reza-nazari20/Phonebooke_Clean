using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhonebook.Services.AddNewContact
{
    public class AddNewContactDto
    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Company { get; set; }
        public required string Description { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
