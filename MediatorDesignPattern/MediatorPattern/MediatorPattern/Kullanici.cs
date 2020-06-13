using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract class Kullanici
    {
        protected ITelefonSantrali telefonSantrali { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciNo { get; set; }

        public Kullanici(ITelefonSantrali santral,string kAdi,string kNo)
        {
            this.telefonSantrali = santral;
            this.kullaniciAdi = kAdi;
            this.kullaniciNo = kNo;
        }
        public abstract void MesajAl(string mesaj, Kullanici kullanici);
        public abstract void MesajGonder(string mesaj, string gonderilenNo);
    }
}
