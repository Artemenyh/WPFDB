using WPFDB.Models;
using Microsoft.EntityFrameworkCore;

namespace WPFDB.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Students> Students { get; set; }

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BORIS;Database=Phones;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}