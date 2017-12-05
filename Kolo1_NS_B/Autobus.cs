using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_B
{
    class Autobus:SrodekLokomocji
    {
        private bool klimatyzacja;

        public Autobus(string model, int iloscMiejsc, bool klimatyzacja)
            :base(model,iloscMiejsc)
        {
            this.klimatyzacja = klimatyzacja;
        }

        public double Bilet()
        {
            return 5.2;
        }
    }
}
