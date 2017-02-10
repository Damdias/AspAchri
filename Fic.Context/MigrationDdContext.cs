using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fic.DataEntity;

namespace Fic.Context
{
  public  class MigrationDdContext:DbContext
    {
        public MigrationDdContext():base("MigrationDb")
        {

        }
      public DbSet<Customer> Customers { get; set; }
    }
}
