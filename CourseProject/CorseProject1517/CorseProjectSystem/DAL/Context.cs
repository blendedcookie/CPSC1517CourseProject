using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CorseProjectSystem.Entity;
using CorseProjectSystem.Data;

namespace CorseProjectSystem.DAL
{
   internal class Context:DbContext
    {
        //,schema.sales ""????
        public  Context() : base("CSPC157")
        {

        }

        
        public DbSet<ModifiedDate> ModifiedDate { get; set; }
        public DbSet<Name> Name { get; set; }
        public DbSet<rowguid> rowguid { get; set; }
        public DbSet<ShipBase> ShipBase { get; set; }
        public DbSet<ShipRate> ShipRate { get; set; }
    }
}
