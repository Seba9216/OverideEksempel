using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideEksempel
{
    public class DrengeBarn : Barn
    {
        //eksmpel på at vi implementere en bool fra den abstrakte klasse der hedder Barn
        public override bool HarKolik()
        {
            return false;
        }
    }
}
