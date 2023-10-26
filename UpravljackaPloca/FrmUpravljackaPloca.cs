using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljackaPloca
{
    public partial class FrmUpravljackaPloca : Form
    {
        private ElektronickiUpravljac upravljac = new ElektronickiUpravljac();
        public FrmUpravljackaPloca()
        {
            InitializeComponent();
        }

        private void FrmUpravljackaPloca_Load(object sender, EventArgs e)
        {
            dgvPopisOtvora.DataSource = upravljac.Otvori;
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            var dgvItem = dgvPopisOtvora.CurrentRow;
            if (dgvItem != null )
            {
                var otvor = dgvItem.DataBoundItem as IOtvor;
                otvor.Otvori();
            }
            dgvPopisOtvora.DataSource = null;
            dgvPopisOtvora.DataSource = upravljac.Otvori;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            var dgvItem = dgvPopisOtvora.CurrentRow;
            if (dgvItem != null)
            {
                var otvor = dgvItem.DataBoundItem as IOtvor;
                otvor.Zatvori();
            }
            dgvPopisOtvora.DataSource = null;
            dgvPopisOtvora.DataSource = upravljac.Otvori;
        }

        private void btnOtvoriSve_Click(object sender, EventArgs e)
        {
            upravljac.OtvoriSve();
            dgvPopisOtvora.DataSource = null;
            dgvPopisOtvora.DataSource = upravljac.Otvori;
        }

        private void btnZatvoriSve_Click(object sender, EventArgs e)
        {
            upravljac.ZatvoriSve();
            dgvPopisOtvora.DataSource = null;
            dgvPopisOtvora.DataSource = upravljac.Otvori;
        }
    }
}
