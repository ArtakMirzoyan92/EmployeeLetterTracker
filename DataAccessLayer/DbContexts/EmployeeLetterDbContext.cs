using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DbContexts
{
    public class EmployeeLetterDbContext : DbContext
    {            
        public EmployeeLetterDbContext(DbContextOptions<EmployeeLetterDbContext> options)
            : base(options) 
        {
             Database.Migrate();           
        }
       
        public DbSet<EmployeeLetter> EmployeeLetters { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
               => optionsBuilder.UseSqlServer("Server=LAPTOP-HSSTA1HS;Database=TestDB;Trusted_Connection=true;");
    }
}
