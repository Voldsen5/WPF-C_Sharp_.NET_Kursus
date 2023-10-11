using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lektion08_01.MODEL;
using Lektion08_01.DAL;

namespace Lektion08_01.DAL
{
    internal class BilInitializer : CreateDatabaseIfNotExists<BilContext>
    {
        protected override void Seed(BilContext context)
        {
            context.Biler.Add(new Bil("Mclaren", 1500));
            context.SaveChanges();
        }

        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
