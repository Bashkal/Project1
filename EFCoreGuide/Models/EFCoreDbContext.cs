using Microsoft.EntityFrameworkCore;

namespace EFCoreGuide.Models
{
    public class EFCoreDbContext:DbContext
    {
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Guide> Guides{ get; set; }
        public DbSet<Brand> Brands{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFCoreGuide;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Brand>()
                .Property(b => b.Name)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
