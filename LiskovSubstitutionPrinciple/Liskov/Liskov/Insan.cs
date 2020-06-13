using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public abstract class Insan
    {
        public void BilgiYazdir()
        {
            Console.WriteLine("AdSoyad = {0} , Yaş = {1}", this.AdSoyad, this.Yas);
        }
        public int Yas { get; set; }
        public string AdSoyad { get; set; }
        public void TvIzle()
        {
            Console.WriteLine("Insan {0}, kişisi tv izliyor.", this.AdSoyad);
        }
        public void YemekYe()
        {
            Console.WriteLine("Insan {0}, kişisi tv izliyor.", this.AdSoyad);
        }
    }
}
