using Quarantracker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quarantracker.DAL
{
    public class HobbyContext : DbContext
    {
        public HobbyContext() : base("HobbyContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}