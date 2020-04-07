using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonNesne
    {
        private static SingletonNesne dondurulecek;
        private SingletonNesne()
        {

        }
        public static SingletonNesne NesneOlustur()
        {
            if (dondurulecek == null)
            {
                dondurulecek = new SingletonNesne();
            }
            return dondurulecek;
        }

    }
}
