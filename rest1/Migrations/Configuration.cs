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
            DbContext.products.AddOrUpdate(
                p => p.id,
            new product { id = "Б7583", name = "синие брюки", price = "700", department = 2 },
            new product { id = "БЛ738", name = "рубашка белая", price = "800", department = 4 },
            new product { id = "Д344", name = "скини", price = "1200", department = 3 },
            new product { id = "П21313", name = "голубое платье", price = "500", department = 1 },
            new product { id = "Т12334", name = "толстовка синяя", price = "1500", department = 5 });
            DbContext.Departments.AddOrUpdate(
                p => p.id,
                new department { name = "платья", curator = "Иванов" },
                new department { name = "брюки", curator = "Петрова" },
                new department { name = "джинсы", curator = "Ковальчук" },
                new department { name = "блузки", curator = "Смирнова" },
                new department { name = "толстовки", curator = "Рожкова" });

        }
    }
}
