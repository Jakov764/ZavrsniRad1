using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    public class Sladoled
    {
        int brojKuglica;
        string oblikSladoled;
        double cijena;
        double cijenaOblika;

        public Sladoled(int brojKuglica, string oblik, double cijena)
        {
            this.brojKuglica = brojKuglica;
            this.oblikSladoled = oblik;
            this.cijena = cijena;
        }

        

        public int BrojKuglica { get => brojKuglica; set => brojKuglica = value; }
        public string OblikSladoled { get => oblikSladoled; set => oblikSladoled = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double CijenaOblika { get => cijenaOblika; set => cijenaOblika = value; }


        /*
        public double Izracun()
        {
            if ()
            {
                this.CijenaOblika = 5.00;
            }
            else
            {
                this.CijenaOblika = 7.00;
            }

            this.cijena = CijenaOblika * brojKuglica;

            return cijena;
        }
        */


        public override string ToString()
        {
            return ("Broj kuglica: " + brojKuglica + ",     Oblik: " + oblikSladoled + ",     Cijena: " + cijena + "\r\n");
        }
    }

}
