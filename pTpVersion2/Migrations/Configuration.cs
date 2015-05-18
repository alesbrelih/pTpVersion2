using System.Collections.Generic;
using pTpVersion2.Data.DatabaseModels;

namespace pTpVersion2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<pTpVersion2.Data.DatabaseModels.DbContext.PtpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(Data.DatabaseModels.DbContext.PtpContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //new List<Person>
            //{
            //    new Person(){Name = "Primož",Surname = "Kragelj",Email = "metalbiker@Stuff.si",Telephone = "080888888",Foreigner = false},
            //    new Person(){Name = "Jožica", Surname = "Kragelj",Email = "slut@slut.sl",Telephone = "080008800",Foreigner = true}
            //}.ForEach(x=>context.Persons.AddOrUpdate(x));
            //context.SaveChanges();
            //base.Seed(context);

        }
    }
}
