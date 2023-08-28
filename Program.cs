using System.Security.Cryptography.X509Certificates;

namespace OverideEksempel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Mand mand = new Mand();
            AtypiskFrue Dame = new AtypiskFrue();
            Console.WriteLine(person.Hvemerjeg());
            //eksmpel på mit brug af base,Sealed og New 
            Console.WriteLine(Dame.Hvemerjeg());
            //Typecaster jeg til en stormand som også er mand
            mand = new StorMand(); 
            Console.WriteLine(mand.Hvemerjeg());  
        }
    }
}