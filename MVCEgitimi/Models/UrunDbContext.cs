using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCEgitimi.Models
{
    public partial class UrunDbContext : DbContext
    {
        public UrunDbContext()
            : base("name=UrunDbContext")
        {
        }

        public virtual DbSet<Categories> Categories
        {
            get; set;
        }
        public virtual DbSet<Guides> Guides
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Guides)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
