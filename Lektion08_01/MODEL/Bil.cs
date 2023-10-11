using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion08_01.MODEL
{
    public class Bil
    {
        public int BilID {  get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public virtual Firma Firma { get; set; }

        public Bil() { }

        public Bil(string _name, int _weight)
        {
            Name = _name;
            Weight = _weight;
        }

        public override string ToString()
        {
            return "Navn: " + Name + ", Vægt: " + Weight;
        }
    }
}
