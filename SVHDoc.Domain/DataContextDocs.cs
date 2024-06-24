using SVHDB.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SVHDB
{
    public class DataContextDocs: DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Package> Packages { get; set; }

        public DbSet<Document> Documents { get; set; }
       
        public DbSet<Status> Status { get; set; }

        public DbSet<StatusGraph> StatusGraph { get; set; }

        public DataContextDocs()
        {
            Database.EnsureCreated();


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(p => p.Packages)
                 .WithOne(u => u.User)
                 .HasForeignKey(p => p.UserId);


            modelBuilder.Entity<Package>()
                 .HasMany(d => d.Documents)
                 .WithOne(p => p.Packages)
                 .HasForeignKey(d => d.Pid);


            modelBuilder.Entity<Document>()
                .HasKey(d=>new { d.Id,d.Pid,d.Idmd5,d.IdSha256 });

            modelBuilder.Entity<Status>()
                .HasKey(s => new { s.Id });

            modelBuilder.Entity<StatusGraph>()
                .HasKey(s => new {s.oldst, s.newst });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=studotus;Database=SVHDocs");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
