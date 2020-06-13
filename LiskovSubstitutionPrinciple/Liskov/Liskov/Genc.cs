using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Genc : Insan, IDisariCikabilir
    {
        public Genc(string AdSoyad,int Yas)
        {
            this.AdSoyad = AdSoyad;
            this.Yas = Yas;
        }
        public void DisariCik()
        {
            Console.WriteLine("Genc {0} kişisi ({1}yaşında) dışarı çıkabilir", this.AdSoyad, this.Yas);
        }
    }
}
