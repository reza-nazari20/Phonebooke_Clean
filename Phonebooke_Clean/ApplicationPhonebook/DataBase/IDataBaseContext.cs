using DomainPhonebook.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationPhonebook.DataBase
{
    public interface IDataBaseContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public int SaveChanges();
    }
}
