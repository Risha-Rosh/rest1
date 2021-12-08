using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace rest1.Models
{
    public class DataContext : DbContext
    {
        public DbSet<product> products { get; set; }
        public DbSet<department> departments { get; set; }
    }
}
