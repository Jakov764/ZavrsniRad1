using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekŠpraljaJakovZavrsniRad
{
    public partial class Form1 : Form
    {
        // ovdje definirati sve varijable (broj kuglica)
        int brojKuglicaCoko;
        int brojKuglicaVan;
        int brojKuglicaJag;
        int brojKuglicaStrac;
        int brojKuglicaPist;
        int brojKuglicaKeks;
        int brojKuglicaSladoled;
        double ukupnaCijena = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            
            double total = 0;
            
            foreach (Sladoled sladoled in racun)
            {
                double cijena = sladoled.Cijena;
                total += cijena;
            }
            

            Racun rac = new Racun(total, DateTime.Now);

            richTextBox1.Text = rac.ToString();
            
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }
        

        
        private void btnCokoPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxCoko.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxCoko.Checked = true;

            }

            if (checkBoxCoko.Checked)
            {
                brojKuglicaCoko = Convert.ToInt32(this.textBoxCoko.Text);
                brojKuglicaCoko++;
                textBoxCoko.Text = Convert.ToString(brojKuglicaCoko);
            }


        }

        private void btnCokoMin_Click(object sender, EventArgs e)
        {
            if (checkBoxCoko.Checked)
            {
                brojKuglicaCoko--;
                textBoxCoko.Text = Convert.ToString(brojKuglicaCoko);
            }

            if (brojKuglicaCoko == 0)
            {
                checkBoxCoko.Checked = false;
            }
        }

        private void btnVanPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxVan.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxVan.Checked = true;

            }

            if (checkBoxVan.Checked)
            {
                brojKuglicaVan = Convert.ToInt32(this.textBoxVan.Text);
                brojKuglicaVan++;
                textBoxVan.Text = Convert.ToString(brojKuglicaVan);
            }

        }

        private void btnVanMin_Click(object sender, EventArgs e)
        {
            if (checkBoxVan.Checked)
            {
                brojKuglicaVan--;
                textBoxVan.Text = Convert.ToString(brojKuglicaVan);
            }

            if (brojKuglicaVan == 0)
            {
                checkBoxVan.Checked = false;
            }
        }

        private void btnJagPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxJag.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxJag.Checked = true;

            }

            if (checkBoxJag.Checked)
            {
                brojKuglicaJag = Convert.ToInt32(this.textBoxJag.Text);
                brojKuglicaJag++;
                textBoxJag.Text = Convert.ToString(brojKuglicaJag);
            }
        }

        private void btnJagMin_Click(object sender, EventArgs e)
        {
            if (checkBoxJag.Checked)
            {
                brojKuglicaJag--;
                textBoxJag.Text = Convert.ToString(brojKuglicaJag);
            }

            if (brojKuglicaJag == 0)
            {
                checkBoxJag.Checked = false;
            }
        }

        private void btnStracPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxStrac.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxStrac.Checked = true;

            }

            if (checkBoxStrac.Checked)
            {
                brojKuglicaStrac = Convert.ToInt32(this.textBoxStrac.Text);
                brojKuglicaStrac++;
                textBoxStrac.Text = Convert.ToString(brojKuglicaStrac);
            }
        }

        private void btnStracMin_Click(object sender, EventArgs e)
        {
            if (checkBoxStrac.Checked)
            {
                brojKuglicaStrac--;
                textBoxStrac.Text = Convert.ToString(brojKuglicaStrac);
            }

            if (brojKuglicaStrac == 0)
            {
                checkBoxStrac.Checked = false;
            }
        }

        private void btnPisPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxPis.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxPis.Checked = true;

            }

            if (checkBoxPis.Checked)
            {
                brojKuglicaPist = Convert.ToInt32(this.textBoxPis.Text);
                brojKuglicaPist++;
                textBoxPis.Text = Convert.ToString(brojKuglicaPist);
            }
        }

        private void btnPisMin_Click(object sender, EventArgs e)
        {
            if (checkBoxPis.Checked)
            {
                brojKuglicaPist--;
                textBoxPis.Text = Convert.ToString(brojKuglicaPist);
            }

            if (brojKuglicaPist == 0)
            {
                checkBoxPis.Checked = false;
            }
        }

        private void btnKeksPlus_Click(object sender, EventArgs e)
        {
            if (!checkBoxKeks.Checked)
            {              //kod za cekiranje sladoleda
                checkBoxKeks.Checked = true;

            }

            if (checkBoxKeks.Checked)
            {
                brojKuglicaKeks = Convert.ToInt32(this.textBoxKeks.Text);
                brojKuglicaKeks++;
                textBoxKeks.Text = Convert.ToString(brojKuglicaKeks);
            }
        }

        private void btnKeksMin_Click(object sender, EventArgs e)
        {
            brojKuglicaKeks = Convert.ToInt32(this.textBoxKeks.Text);
            if (checkBoxKeks.Checked)
            {
                brojKuglicaKeks--;
                textBoxKeks.Text = Convert.ToString(brojKuglicaKeks);
            }

            if (brojKuglicaKeks == 0)
            {
                checkBoxKeks.Checked = false;
            }
        }

        List<Sladoled> racun = new List<Sladoled>();

        bool oblikSladoled;

        string stanje;

        private void BtnGotov_Click(object sender, EventArgs e)
        {
            brojKuglicaSladoled = 0;
            brojKuglicaSladoled = brojKuglicaCoko + brojKuglicaVan + brojKuglicaJag + brojKuglicaStrac + brojKuglicaPist + brojKuglicaKeks;
            double cijena = 0.00;


            if (radBtnKorn.Checked)
            {
                oblikSladoled = true;
                stanje = "Kornet";
                cijena = 7 * brojKuglicaSladoled;
            }

            if (radBtnCasa.Checked)
            {
                oblikSladoled = false;
                stanje = "Čaša";
                cijena = 12 * brojKuglicaSladoled;
            }
            Sladoled obj = new Sladoled(brojKuglicaSladoled, stanje, cijena);

            racun.Add(obj);

            

            checkBoxCoko.Checked = false;
            checkBoxVan.Checked = false;
            checkBoxJag.Checked = false;
            checkBoxStrac.Checked = false;
            checkBoxPis.Checked = false;
            checkBoxKeks.Checked = false;

            textBoxCoko.Text = "0";
            textBoxVan.Text = "0";
            textBoxJag.Text = "0";
            textBoxStrac.Text = "0";
            textBoxPis.Text = "0";
            textBoxKeks.Text = "0";

            brojKuglicaCoko = 0;
            brojKuglicaVan = 0;
            brojKuglicaJag = 0;
            brojKuglicaStrac = 0;
            brojKuglicaPist = 0;
            brojKuglicaKeks = 0;

            radBtnCasa.Checked = false;
            radBtnKorn.Checked = false;

            richTextBox1.AppendText(obj.ToString());

            /*
            if (!checkBoxCoko.Checked && !checkBoxVan.Checked && !checkBoxJag.Checked && !checkBoxStrac.Checked && !checkBoxPis.Checked && !checkBoxKeks.Checked)
            {
                MessageBox.Show("Niste unijeli koji okus želite.\r\nMolim odaberite ponovo.");
            }

            if (!radBtnKorn.Checked && !radBtnCasa.Checked)
            {
                MessageBox.Show("Niste unijeli oblik koji želite.\r\nMolim odaberite ponovo.");
            }

            int brojKuglicaSladoleda = brojKuglicaCoko + brojKuglicaVan + brojKuglicaJag + brojKuglicaStrac + brojKuglicaPist + brojKuglicaKeks;
            

            // čemu služi ovo? - 
            if(checkBoxCoko.Checked || checkBoxVan.Checked || checkBoxJag.Checked || checkBoxStrac.Checked || checkBoxPis.Checked || checkBoxKeks.Checked && radBtnKorn.Checked || radBtnCasa.Checked)
            {
                if (radBtnKorn.Checked)
                {
                    int cijenaKor1 = cijenaKor * brojKuglicaSladoleda;
                    ukupnaCijenaKor = ukupnaCijenaKor + cijenaKor1;
                }

                if (radBtnCasa.Checked)
                {
                    int cijenaCasa1 = cijenaCasa * brojKuglicaSladoleda;
                    ukupnaCijenaKor = ukupnaCijenaKor + cijenaCasa1;
                }

                ukupnaCijena = ukupnaCijenaKor + ukupnaCijenaCasa;

                
            }

            */



            // koji je oblik?

            // kreirati objekt sladoled s brojem kuglica i oblikom
            //    Sladoled sladoled = new Sladoled(int brojKuglicaSladoled,bool oblikSladoleda);

            // richTextBox.AppendText(sladoled.ToString());

        }

        
        /*
        public override string ToString()
        {
            return ("Broj kuglica: " + brojKuglicaSladoled + ", Oblik: " + stanje +  ", Cijena: " + "" + "\r\n" + brojKuglicaKeks.ToString() );
        }
        */
    }
}