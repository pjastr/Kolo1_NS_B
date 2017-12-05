using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_B
{
    class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected string model;

        public SrodekLokomocji(string model, int iloscMiejsc)
        {
            this.model = model;
            this.iloscMiejsc = iloscMiejsc;
        }

        public void Info()
        {
            Console.WriteLine(model + " " + iloscMiejsc);
        }
    }
}
