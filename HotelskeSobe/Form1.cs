using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelskeSobe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaziSlobodne_Click(object sender, EventArgs e)
        {
            DateTime datum = dtpDatum.Value.Date;
            var slobodneSobe = dgvSlobodneSobe;

            slobodneSobe.DataSource = Recepcija.DohvatiSlobodneSobe(datum);
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            DateTime datum = dtpDatum.Value.Date;
            var dgvSoba = dgvSlobodneSobe.CurrentRow;

            if (dgvSoba != null)
            {
                HotelskaSoba soba = dgvSoba.DataBoundItem as HotelskaSoba;
                Recepcija.Rezerviraj(soba, datum);

                dgvSlobodneSobe.DataSource = Recepcija.DohvatiSlobodneSobe(datum);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
