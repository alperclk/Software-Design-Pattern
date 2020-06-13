using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    interface ITelefonSantrali //Mediator Interface
    {
        void MesajGonder(string mesaj, Kullanici kullanici, string gonderilenNo);
        void KullaniciEkle(Kullanici kullanici);
    }
}
