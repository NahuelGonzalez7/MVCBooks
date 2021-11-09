using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBook.Data
{
    public class DbBookContext : DbContext
    {
        public DbBookContext() : base("KeyDb") { }

        public DbSet<Book> books { get; set; }
    }
}