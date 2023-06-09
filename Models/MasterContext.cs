using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test.Models;

namespace Test.Models
{
    public class MasterContext : DbContext
    {
        public MasterContext() : base()
        {

        }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}