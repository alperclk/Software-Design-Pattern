using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    interface IComponentCalisan
    {
        void ElemanDetay();
        
        string AdSoyad { get; set; }
        Pozisyonlar Pozisyon { get; set; }
        void IsYap(string Is);

    }
}
