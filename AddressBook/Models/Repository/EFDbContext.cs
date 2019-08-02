using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AddressBook.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }
}