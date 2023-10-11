using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08_01.MODEL
{
    public class Firma
    {
        public int FirmaID { get; set; }
        public string Name { get; set; }
        public Firma() { }

        public Firma(string firmaName)
        {  
            this.Name = firmaName;
        }

        public override string ToString()
        {
            return "Firma: " + Name + " ";
        }
    }
}
