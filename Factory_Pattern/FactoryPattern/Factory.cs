using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Factory
    {

        public Sekil SekilDondur(String SekilAdi)
        {
            if (SekilAdi.Equals("Ucgen"))
            {
                return new Ucgen();
            }

            else if (SekilAdi.Equals("Kare"))
            {
                return new Kare();
            }

            else if (SekilAdi.Equals("Altigen"))
            {
                return new Altigen();
            }



            return null;
        }

    }
}
