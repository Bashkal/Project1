namespace WindowsFormsAppEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsAppEFCodeFirst.GuideDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WindowsFormsAppEFCodeFirst.GuideDBContext";
        }

        protected override void Seed(WindowsFormsAppEFCodeFirst.GuideDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
