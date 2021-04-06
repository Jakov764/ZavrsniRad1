using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    class Racun
    {
        static int brojRac = 0;
        double total;
        DateTime datum;
        int broj;

        public Racun(double total, DateTime datum)
        {
            this.total = total;
            this.datum = datum;
            this.broj = brojRac++;
        }

        public override string ToString()
        {
            string ispis = "Racun broj: " + broj + "\r\n" + "Datum: " + datum + "\r\n" + "Total: " + total + "kn";
            return ispis;
        }

    }
}
