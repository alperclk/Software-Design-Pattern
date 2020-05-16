using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_DesignPattern
{
    class MeyveConcreteAggregate : IMeyveAggregate
    {
        private List<Meyve> meyveListesi = new List<Meyve>();
        public int meyveSayisi { get { return meyveListesi.Count; } }
        public void Add(Meyve m)
        {
            meyveListesi.Add(m);
        }

        public Meyve GetItem(int index)
        {
            return meyveListesi[index];
        }

        public IMeyveIterator getIterator()
        {
            return new MeyveConcreteIterator(this);
        }
    }
}
