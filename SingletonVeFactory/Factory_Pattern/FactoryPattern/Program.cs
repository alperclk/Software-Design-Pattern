using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Sekil ucgen = factory.SekilDondur("Ucgen");
            ucgen.CevreHesapla(4);

            Sekil kare = factory.SekilDondur("Kare");
            kare.CevreHesapla(4);

            Sekil altigen = factory.SekilDondur("Altigen");
            altigen.CevreHesapla(4);

            Console.Read();
        }
    }
}
