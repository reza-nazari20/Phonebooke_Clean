using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhonebook.Services.AddNewContact
{
    public class AddNewContactDto
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Phonenumber { get; set; }

        public string Description { get; set; }

        public string Company { get; set; }
    }
}
