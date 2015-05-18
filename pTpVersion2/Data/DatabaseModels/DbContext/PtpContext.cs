using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels.DbContext
{
    public class PtpContext:System.Data.Entity.DbContext
    {
        public PtpContext() : base("PtpContext")
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Firm> Firms { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
