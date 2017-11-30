using CrossCutting.Data.Configurations.Auth;
using Domain.Entities.Auth;
using System.Data.Entity;

namespace CrossCutting.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DefaultConnection"){}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
