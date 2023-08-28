using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideEksempel
{
    public class Person
    {
        public int id { get; set; }

        public virtual string Hvemerjeg() { return "Jeg er en person";  }

    }
}
