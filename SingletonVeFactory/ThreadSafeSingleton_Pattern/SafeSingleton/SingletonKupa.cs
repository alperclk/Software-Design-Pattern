using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeSingleton
{
    public sealed class SingletonKupa
    {
        private static int counter = 0;
        private SingletonKupa()
        {
            Console.WriteLine("{0} kere constructor methodu calisti", counter);
        }
        private static SingletonKupa singletonKupa = null;
        private static readonly object Lock = new object();
        
        public static SingletonKupa KupayiAl
        {
            get
            {
                lock (Lock)
                {
                    if (singletonKupa == null)
                    {
                        counter++;
                        singletonKupa = new SingletonKupa();
                        
                    }
                }
                return singletonKupa;
            }
        }

    }
}
