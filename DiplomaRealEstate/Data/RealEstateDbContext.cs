using DiplomaRealEstate.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlazorApp10.Data
{
    public class RealEstateDbContext : IdentityDbContext<User>
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TypeRealEstate> TypeRealEstates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QHR1LI1\\MSSQLSERVERR;database=Diploma;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            // Пример добавления данных в таблицу Statuses
            modelBuilder.Entity<Category>().HasData(
                new Status { Id = Guid.NewGuid(), Name = "Жилая собственность" },
                new Status { Id = Guid.NewGuid(), Name = "Земельные участок" }
            );

            // Пример добавления данных в таблицу TypeRealEstates
            modelBuilder.Entity<TypeRealEstate>().HasData(
                new TypeRealEstate { Id = Guid.NewGuid(), Name = "Дом " },
                new TypeRealEstate { Id = Guid.NewGuid(), Name = "Земельный участок" }
            );

            modelBuilder.Entity<Status>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Продано" },
                new Category { Id = Guid.NewGuid(), Name = "Арендована" },
                new Category { Id = Guid.NewGuid(), Name = "Активная" }
            );

        }
    }
}
