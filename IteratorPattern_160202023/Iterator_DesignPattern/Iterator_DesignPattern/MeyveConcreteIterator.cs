using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_DesignPattern
{
    class MeyveConcreteIterator : IMeyveIterator
    {
        private MeyveConcreteAggregate meyveler;
        private int index = 0;
        public MeyveConcreteIterator(MeyveConcreteAggregate meyve)
        {
            meyveler = meyve;
        }

        public bool BittiMi()
        {
            if(index < meyveler.meyveSayisi)
            {
                
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Meyve GecerliMeyve()
        {
            return meyveler.GetItem(index);
        }

        public Meyve Next()
        {
            index++;
            if (BittiMi())
            {
                return meyveler.GetItem(index);
            }
            else
            {
                return null;
            }
        }

        

    }
}
