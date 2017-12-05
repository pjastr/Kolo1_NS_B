using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_B
{
    class Program
    {
        static void Main(string[] args)
        {
            SrodekLokomocji s1 = new SrodekLokomocji("sss", 34);
            SrodekLokomocji s2 = new SrodekLokomocji("ttg", 45);
            Autobus a1 = new Autobus("sss", 45, true);
            Autobus a2 = new Autobus("pijj", 67, false);
            Pociag p1 = new Pociag("dfgfg", 34, "sss");
            Pociag p2 = new Pociag("yhb", 22, "qaz");
            a1.Bilet();
            a2.Bilet();
            p1.Bilet(4);
            p2.Bilet(6.4);
            s1.Info();
            s2.Info();
            a1.Info();
            a2.Info();
            p1.Info();
            p2.Info();

            Console.ReadKey();
        }
    }
}
