using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Online_Store_For_Musical_Instrument.Data;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Data
{
    public class Online_Store_For_Musical_InstrumentContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Online_Store_For_Musical_InstrumentContext() : base("MusicalInstrumentConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public static Online_Store_For_Musical_InstrumentContext Create()
        {
            return new Online_Store_For_Musical_InstrumentContext();
        }
        public virtual System.Data.Entity.DbSet<Product> Products { get; set; }
        public virtual System.Data.Entity.DbSet<Admin> Admins { get; set; }
        public virtual System.Data.Entity.DbSet<DeliveryAddress> DeliveryAddresses { get; set; }

        public virtual System.Data.Entity.DbSet<User> Users { get; set; }

        public virtual System.Data.Entity.DbSet<Order> Orders { get; set; }

        public virtual System.Data.Entity.DbSet<OrderMaster> OrderMasters { get; set; }
    }
}
