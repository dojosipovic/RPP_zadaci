using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PrepaidKartica
{
    public partial class PrepaidForm : Form
    {
        private PrepaidKartica _kartica;
        public PrepaidForm()
        {
            InitializeComponent();
        }

        private void PrepaidForm_Load(object sender, EventArgs e)
        {
            _kartica = new PrepaidKartica("HR12312414213");
            txtSerijskiBroj.Text = _kartica.SerijskiBroj;
            txtStatus.Text = "Nije aktivna";
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            _kartica.Aktiviraj();
            btnAktiviraj.Enabled = false;
            txtStatus.Text = "Aktivna";
            txtIznos.Text = _kartica.Iznos.ToString();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            double iznosUplate = double.Parse(txtIznosUplate.Text);
            _kartica.Uplati(iznosUplate);
            txtIznosUplate.Clear();
            if (btnAktiviraj.Enabled == false)
            {
                txtIznos.Text = _kartica.Iznos.ToString();
                txtStatus.Text = "Aktivna";
            }
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            if (btnAktiviraj.Enabled == true)
            {
                txtIznosIsplate.Clear();
                return;
            }

            double iznosIsplate = double.Parse(txtIznosIsplate.Text);
            if (_kartica.Iznos >= iznosIsplate)
            {
                _kartica.Isplati(iznosIsplate);
                txtIznos.Text = _kartica.Iznos.ToString();
            }
            else
            {
                txtStatus.Text = "Nema sredstava";
            }
            txtIznosIsplate.Clear();
        }
    }
}
