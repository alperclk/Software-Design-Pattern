using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => BirinciKosucu(), () => IkinciKosucu());     
            
        }

        private static void BirinciKosucu()
        {
            SingletonKupa birinciKosucu = SingletonKupa.KupayiAl;
            Console.WriteLine("Birinci kosucu");
        }
        private static void IkinciKosucu()
        {
            SingletonKupa ikinciKosucu = SingletonKupa.KupayiAl;
            Console.WriteLine("İkinci kosucu");
            Console.ReadKey();
            
        }

    }
}
