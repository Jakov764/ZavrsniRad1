using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovZavrsniRad
{
    public class Sladoled : Form1
    {
        public int brojKuglica;
        public bool oblikSladoled;
        public double cijena;
        public double cijenaOblika;

        public Sladoled(int brojKuglica, bool oblik)
        {
            this.brojKuglica = brojKuglica;
            this.oblikSladoled = oblikSladoled;
        }

        public int BrojKuglica { get => brojKuglica; set => brojKuglica = value; }
        public bool OblikSladoled { get => oblikSladoled; set => oblikSladoled = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double CijenaOblika { get => cijenaOblika; set => cijenaOblika = value; }

        public double Izracun()
        {
            if (this.oblikSladoled == true)
            {
                this.CijenaOblika = 7.00;
            }
            else
            {
                this.CijenaOblika = 12.00;
            }

            cijena = CijenaOblika * brojKuglica;

            return cijena;
        }


        /*
private string[] oblik = { "Kornet", "Čašica", "Štapić" };



private string[] okus = { "Čokolada", "Vanilija", "Jagoda", "Stracatela", "Pistacio", "Keks" };

public string[] Oblik { get => oblik; set => oblik = value; }
public string[] Okus { get => okus; set => okus = value; }

public Sladoled (string[] Okus, string[] Oblik)
{
this.Okus = Okus;
this.Oblik = Oblik;
}
*/


    }

}
