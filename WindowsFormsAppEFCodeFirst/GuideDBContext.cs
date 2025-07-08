using System.Data.Entity;

namespace WindowsFormsAppEFCodeFirst
{
    class GuideDBContext : DbContext
    {
        public DbSet<Guide> Guides
        {
            get; set;
        }
        public DbSet<Category> Categories
        {
            get;
            set;
        }
    }
}