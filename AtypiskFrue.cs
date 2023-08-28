using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideEksempel
{
    public class TypsikFrue : Dame
    {
        //eksmpel på at jeg siger at alle der arver fra TypiskFrue har nu ikke muligheden for at override metoden Hvemerjeg
        public override sealed  string Hvemerjeg() { return "Jeg er en TypsikFrue"; }



    }

    public class TypiskMadam: TypsikFrue
    {
      //  public override string Hvemerjeg() {return "jeg er en typsik madam"} <---- dette giver en fejl da vores metode hvem er jeg er sealed

    }

    public class AtypiskFrue : TypsikFrue   
    {
        //brug af new key kan "komme forbi" sealed keyworded og stadig bruge base som så gerne skulle returne TypsikFrue Klassen string
        public new string Hvemerjeg() { return  base.Hvemerjeg() + " jeg er en atypisk frue"; }
    
    }

}
