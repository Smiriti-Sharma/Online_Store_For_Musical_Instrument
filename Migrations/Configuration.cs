namespace Online_Store_For_Musical_Instrument.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Online_Store_For_Musical_Instrument.Data.Online_Store_For_Musical_InstrumentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Online_Store_For_Musical_Instrument.Data.Online_Store_For_Musical_InstrumentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(
            new Models.Product()
            {
                ProductId = 1,
                ProductName = "Guitar",
                Category = "String",
                Brand = "Belear",
                Price = 3000,
                ProductDescription = "Acoustic Guitar,Model Number: 41C, Inch BLK Series: Vega",
                QuantityOnHand = 6,
                ProductImage = "~/Content/Images/AcousticGuitar.jpg"
            },
            new Models.Product()
            {
                ProductId = 2,
                ProductName = "Drum",
                Category = "Percussion",
                Brand = "Yamaha",
                Price = 47000,
                ProductDescription = "Acoustic Drum,RDP2F5 Burgundy Glitter Rydeen Acoustic Drum Kit",
                QuantityOnHand = 3,
                ProductImage = "~/Content/Images/AcousticDrum.jpg"
            });

           
        }
    }
}
