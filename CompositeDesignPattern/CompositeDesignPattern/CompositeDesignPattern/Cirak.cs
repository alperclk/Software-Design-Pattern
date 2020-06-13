using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class LeafEleman : IComponentCalisan
    {
        public string AdSoyad { get; set; }
        public Pozisyonlar Pozisyon { get; set; }

        public LeafEleman(string adSoyad, Pozisyonlar pozisyon)
        {
            this.AdSoyad = adSoyad;
            this.Pozisyon = pozisyon;
        }        

        public void ElemanDetay()
        {
            Console.WriteLine("------Ad-Soyad : {0} , Pozisyon : {1}", this.AdSoyad, this.Pozisyon);
        }


        public void IsYap(string Is)
        {
            Console.WriteLine("{0} kişisi {1} işini yapıyor.", this.AdSoyad, Is);
        }
    }
}
