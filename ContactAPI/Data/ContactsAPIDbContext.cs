using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
	public class ContactsAPIDbContext:DbContext
	{
        public ContactsAPIDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
