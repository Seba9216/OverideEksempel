using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideEksempel
{
    //eksmpel på at jeg overidder metoden Hvemerjeg
    public class Dame : Person
    {

        public override string Hvemerjeg() { return "Jeg er en Dame"; }

    }
}
