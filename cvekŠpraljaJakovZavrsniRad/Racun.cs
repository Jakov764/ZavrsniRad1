using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    class Racun
    {
        int brojRac;
        double total;
        DateTime datum;

        public Racun(int brojRac, double total, DateTime datum)
        {
            this.brojRac = brojRac;
            this.total = total;
            this.datum = datum;
        }
    }
}
