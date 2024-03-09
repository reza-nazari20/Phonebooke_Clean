using ApplicationPhonebook.DataBase;
using DomainPhonebook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistencePhonebook.Context
{
    public class DatabaseContext : DbContext, IDataBaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HHQAC3S;Initial Catalog=DbContact;Integrated Security=True; Trust Server Certificate=Yes");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
