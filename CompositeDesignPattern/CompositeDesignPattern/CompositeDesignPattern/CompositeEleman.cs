using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class CompositeEleman : IComponentCalisan
    {
        public string AdSoyad { get ; set ; }
        public Pozisyonlar Pozisyon { get ; set ; }
        public List<IComponentCalisan> elemanListesi;

        public CompositeEleman(string adSoyad, Pozisyonlar pozisyon)
        {
            this.AdSoyad = adSoyad;
            this.Pozisyon = pozisyon;
            elemanListesi = new List<IComponentCalisan>();
        }

        public void Ekle(IComponentCalisan calisan)
        {
            elemanListesi.Add(calisan);
        }

        public void ElemanDetay()
        {
            string tire = new string('-', (int)this.Pozisyon*2);

            Console.WriteLine("{0} Ad-Soyad : {1} , Pozisyon : {2}", tire,this.AdSoyad, this.Pozisyon.ToString());

            foreach (var eleman in elemanListesi)
            {
                
                eleman.ElemanDetay();
            }
        }

        public void Sil(IComponentCalisan calisan)
        {
            elemanListesi.Remove(calisan);
        }

        public void IsYap(string Is)
        {
            Console.WriteLine("{0} kişisi {1} işini yapıyor.", this.AdSoyad, Is);
        }
    }
}
