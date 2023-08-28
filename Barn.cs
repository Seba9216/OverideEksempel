using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideEksempel
{
    //en abstrakt klasse der viser at alle der arver fra denne klasse skal have HarKolik implementert 
    public abstract class Barn
    {

         public abstract bool HarKolik(); 

    }
}
