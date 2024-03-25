using DiplomaRealEstate.Components.Account.Client.Favorites;
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

        public RealEstateDbContext()
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TransactionOrder> TransactionOrders { get; set; }
        public DbSet<TypeRealEstate> TypeRealEstates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        public DbSet<FavoriteRealEstate> FavoriteRealEstates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; database=Diploma;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true");
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
            modelBuilder.Entity<Category>().HasData(
                new Status { Id = Guid.NewGuid(), Name = "Жилая собственность" },
                new Status { Id = Guid.NewGuid(), Name = "Земельные участок" }
            );

            modelBuilder.Entity<TypeRealEstate>().HasData(
                new TypeRealEstate { Id = Guid.NewGuid(), Name = "Дом " },
                new TypeRealEstate { Id = Guid.NewGuid(), Name = "Земельный участок" }
            );

            modelBuilder.Entity<Status>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Продано" },
                new Category { Id = Guid.NewGuid(), Name = "Арендована" },
                new Category { Id = Guid.NewGuid(), Name = "Активная" }
            );
            modelBuilder.Entity<TypeTransaction>().HasData
                (
                    new TypeTransaction { Id = Guid.NewGuid(), Name = "Аренда" },
                    new TypeTransaction { Id = Guid.NewGuid(), Name = "Продажа" },
                    new TypeTransaction { Id = Guid.NewGuid(), Name = "Покупка" }
                );
        }
    }
}