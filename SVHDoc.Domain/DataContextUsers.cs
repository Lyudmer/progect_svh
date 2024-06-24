using SVHDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace SVHDB
{
    public class DataContextUsers : DbContext
    {
        public DbSet<User> Users { get; set; }


        public DataContextUsers()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(p => p.Packages)
                 .WithOne(u => u.User)
                 .HasForeignKey(p => p.UserId); 

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=studotus;Database=SVHUsers");
            base.OnConfiguring(optionsBuilder);
            {

            }
        }
    }
}
