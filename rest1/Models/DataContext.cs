using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace rest1.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {}
        public Microsoft.EntityFrameworkCore.DbSet<product> Products { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<department> Departments { get; set; }
    }
}
