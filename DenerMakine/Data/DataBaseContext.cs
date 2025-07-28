using DenerMakine.Entities;
using Microsoft.EntityFrameworkCore;

namespace DenerMakine.Data
{
    public class DataBaseContext :DbContext
    {
        public DbSet<Department> Departments {get; set;}
        public DbSet<Guide> Guides { get; set;}
        public DbSet<User>Users { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Guide>().ToTable("Guides");
            modelBuilder.Entity<User>().ToTable("Users").HasData(
                new User { 
                    Id=1,
                    Email ="mahmutsamibaskal@gmail.com", 
                    FirstName="Mahmut Sami", 
                    LastName="Başkal", 
                    Password="1234", 
                    UserName="Bashkal",
                    IsAdmin=true,
                    IsActive=true, 
                    CreatedDate=DateTime.MinValue});
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DenerMakine;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
