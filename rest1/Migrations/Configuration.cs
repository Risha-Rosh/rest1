namespace rest1.Migrations
{
    using rest1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<rest1.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(rest1.Models.DataContext context)
        {
            context.products.AddOrUpdate(
                p => p.id,
                new product { id = "dhn2382", name = "asd", price = "2333", department = 1 });
            context.departments.AddOrUpdate(
                p => p.id,
                new department { name = "nnn", curator = "ttttttt" });

        }
    }
}
