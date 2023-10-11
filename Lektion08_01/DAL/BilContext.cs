using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Lektion08_01.MODEL;

namespace Lektion08_01.DAL
{
    public class BilContext : DbContext
    {
        public BilContext() : base("Biler") 
        { 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Bil> Biler { get; set; }
        public DbSet<Firma> Firma { get; set; }
    }
}
