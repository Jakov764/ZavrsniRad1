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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Sladoled> racun = new List<Sladoled>();

        private void Form2_Load(object sender, EventArgs e)
        {
            double total = 0.00;

            foreach (Sladoled sladoled in racun)
            {
                double cijena = sladoled.Cijena;
                total += cijena;
            }

            Racun rac = new Racun(total, DateTime.Now);

            richTextBox1.Text = rac.ToString();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Close();
        }

    }
}
