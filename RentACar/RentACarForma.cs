using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public partial class RentACarForma : Form
    {
        private Vozilo _vozilo;
        public RentACarForma()
        {
            InitializeComponent();
        }

        private void RentACarForma_Load(object sender, EventArgs e)
        {
            _vozilo = new Vozilo("VŽ-100-NO", "Ford focus, 1.6 tdi");

            txtRegistracija.Text = _vozilo.Registracija;
            txtOpisModela.Text = _vozilo.Model;
            txtStatusVozila.Text = "Raspoloživ";
            btnUciniRaspolozivim.Enabled = false;
            btnAktivirajVozilo.Enabled = false;
            btnPredaj.Enabled = false;
            btnPregledaj.Enabled = false;
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            _vozilo.RezervirajVozilo();
            txtDatumRezervacije.Text = _vozilo.DatumRezervacije.ToString();
            btnRezerviraj.Enabled = false;
            txtStatusVozila.Text = "Rezerviran";
            btnPredaj.Enabled = true;
            btnDeaktivirajVozilo.Enabled = false;
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            _vozilo.PredajVozilo();
            txtDatumPredavanja.Text = _vozilo.DatumPredavanja.ToString();
            btnPredaj.Enabled = false;
            txtStatusVozila.Text = "U uporabi";
            btnPregledaj.Enabled = true;
            txtPregledNapravio.Enabled = true;
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            _vozilo.PregledajVozilo(txtPregledNapravio.Text);
            btnPregledaj.Enabled = false;
            txtPregledNapravio.Enabled = false;
            txtStatusVozila.Text = "Na pregledu";
            btnUciniRaspolozivim.Enabled = true;
        }

        private void btnUciniRaspolozivim_Click(object sender, EventArgs e)
        {
            _vozilo.UciniRaspolozivim();
            txtStatusVozila.Text = "Raspoloživ";
            btnDeaktivirajVozilo.Enabled = true;
            btnRezerviraj.Enabled = true;
            btnUciniRaspolozivim.Enabled = false;
        }

        private void btnAktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.AktivirajVozilo();
            txtStatusVozila.Text = "Raspoloživ";
            btnAktivirajVozilo.Enabled = false;
            btnDeaktivirajVozilo.Enabled = true;
            btnRezerviraj.Enabled = true;
        }

        private void btnDeaktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.DeaktivirajVozilo();
            txtStatusVozila.Text = "U kvaru";
            btnRezerviraj.Enabled = false;
            btnAktivirajVozilo.Enabled = true;
            btnDeaktivirajVozilo.Enabled = false;
        }
    }
}
    