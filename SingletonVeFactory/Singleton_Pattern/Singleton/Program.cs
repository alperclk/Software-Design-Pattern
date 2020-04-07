using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            SingletonNesne a = SingletonNesne.NesneOlustur();
            SingletonNesne b = SingletonNesne.NesneOlustur();

            if (a == b)
            {
                Console.WriteLine("Olusturulan a ve b nesneleri eşittir");
            }
            Console.ReadKey();

        }
    }
}
