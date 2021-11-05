using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCBook.Models;

namespace MVCBook.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext() : base("KeyDB") { }

        public DbSet<Book> Books { get; set; }
    }
}