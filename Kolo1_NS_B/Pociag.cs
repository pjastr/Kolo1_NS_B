using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_B
{
    class Pociag:SrodekLokomocji
    {
        private string kategoria;

        public Pociag(string model, double p1, string kategoria)
            :base(model, (int) p1)
        {
            this.kategoria = kategoria;
        }

        public double Bilet(double p1)
        {
            return 12.7 * p1;
        }
    }
}
