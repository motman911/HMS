using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace HMS.Data
{
    public class App_Db_Contacts : DbContext
    {
        public App_Db_Contacts(DbContextOptions<App_Db_Contacts>options) : base(options)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
