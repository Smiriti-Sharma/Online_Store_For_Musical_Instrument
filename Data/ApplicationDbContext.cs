using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("MusicalInstrumentDBContext")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}