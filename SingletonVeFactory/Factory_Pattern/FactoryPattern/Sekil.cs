using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface Sekil
    {
        void CevreHesapla(int kenar);
    }

    public class Ucgen : Sekil
    {
        public void CevreHesapla(int kenar)
        {
            Console.WriteLine("Eşkenar üçgenin çevresi {0}", kenar * 3);
        }
    }

    public class Kare : Sekil
    {
        public void CevreHesapla(int kenar)
        {
            Console.WriteLine("Karenin çevresi {0}", kenar * 4);
        }
    }

    public class Altigen : Sekil
    {
        public void CevreHesapla(int kenar)
        {
            Console.WriteLine("Altigenin çevresi {0}", kenar * 6);
        }
    }

}
