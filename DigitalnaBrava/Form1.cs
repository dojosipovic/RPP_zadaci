using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalnaBrava
{
    public partial class BravaForm : Form
    {
        public BravaForm()
        {
            InitializeComponent();
        }

        private void btn501_Click(object sender, EventArgs e)
        {
            Otvori(501);
        }

        private void btn502_Click(object sender, EventArgs e)
        {
            Otvori(502);
        }

        private void btn503_Click(object sender, EventArgs e)
        {
            Otvori(503);
        }

        private void Otvori(int brVrata)
        {
            int brKartice;
            int pin;
            bool karticaParse = int.TryParse(tbBrojKartice.Text, out brKartice);
            bool pinParse = int.TryParse(tbPin.Text, out pin);

            if (pinParse && karticaParse)
            {
                bool uspjesno = SigurnosnaKontrola.OtvoriVrata(brKartice, pin, brVrata);

                MessageBox.Show(
                    uspjesno ?
                        "Vrata uspješno otvorena!" :
                        "Vrata nije moguće otvoriti"
                );
            }
            else
            {
                MessageBox.Show("Nevaljali podaci!");
            }
        }
    }
}
