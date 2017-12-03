using Microsoft.EntityFrameworkCore;

using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=healthcatalyst.db");
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.ApplyConfiguration(new PersonConfiguration());
        //}
    }
}