using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RadniNalog
{
    public partial class RadniNalogForm : Form
    {
        private RadniNalog _radniNalog;
        public RadniNalogForm()
        {
            InitializeComponent();
        }

        private void RadniNalogForm_Load(object sender, EventArgs e)
        {
            _radniNalog = new RadniNalog();
            txtStatus.Text = "Kreiran";
            btnOtkaziNalog.Enabled = false;
            btnPredajNalog.Enabled = false;
            btnZapocniProizvodnju.Enabled = false;
            btnDovrsiProizvodnju.Enabled = false;
        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
            if (txtOpis.Text.Trim() != "")
            {
                _radniNalog.ZakljucajNalog(txtOpis.Text);
                txtDatumKreiranja.Text = _radniNalog.DatumKreiranja.ToString();
                btnZakljucaj.Enabled = false;
                txtOpis.Enabled = false;
                txtStatus.Text = "Zaključan";
                btnOtkaziNalog.Enabled = true;
                btnPredajNalog.Enabled = true;
            }
        }

        private void btnPredajNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.PredajUProizvodnju(dtpDatumPredaje.Value);
            btnOtkaziNalog.Enabled = false;
            btnZapocniProizvodnju.Enabled = true;
            btnPredajNalog.Enabled = false;
            dtpDatumPredaje.Enabled = false;
            txtStatus.Text = "Predan u proizvodnju";
        }

        private void btnZapocniProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.ZapocniProizvodnju(dtpDatumPocetka.Value);
            btnZapocniProizvodnju.Enabled = false;
            dtpDatumPocetka.Enabled = false;
            btnDovrsiProizvodnju.Enabled = true;
            txtStatus.Text = "Započeta proizvodnja";
        }

        private void btnDovrsiProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.DovrsiProizvodnju(dtpDatumDovrsetka.Value);
            txtStatus.Text = "Dovršena proizvodnja";
            btnDovrsiProizvodnju.Enabled = false;
            dtpDatumDovrsetka.Enabled = false;
        }

        private void btnOtkaziNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.OtkaziNalog();
            txtStatus.Text = "Otkazan";
            btnPredajNalog.Enabled = false;
            btnOtkaziNalog.Enabled = false;
        }
    }
}
