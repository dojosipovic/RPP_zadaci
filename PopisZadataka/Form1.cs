using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopisZadataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrikaziZadatke()
        {
            dgvZadaci.DataSource = ZadatakRepozitorij.DohvatiZadatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DateTime rok = dtpRok.Value.Date;
            string naziv = tbNaziv.Text.Trim();

            if (naziv != "")
            {
                ZadatakRepozitorij.DodajZadatak(naziv, rok);
                tbNaziv.Text = "";
            }

            dgvZadaci.DataSource = null;
            dgvZadaci.DataSource = ZadatakRepozitorij.DohvatiZadatke();
        }
    }
}
