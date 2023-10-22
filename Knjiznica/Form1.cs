using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class DodajClana : Form
    {
        public DodajClana()
        {
            InitializeComponent();
        }

        private bool ProvjeriIspravnost()
        {
            var ime = tbIme.Text;
            var prezime = tbPrezime.Text;
            bool ispravno = true;

            if (ime == "")
            {
                MessageBox.Show("Ime je prazno!");
                ispravno = false;
            }
            else if (prezime == "")
            {
                MessageBox.Show("Prezime je prazno!");
                ispravno = false;
            }

            return ispravno;
        }

        private void PrikaziRezultat(Clan noviClan)
        {
            if (noviClan == null)
            {
                MessageBox.Show("Član već postoji!");
            }
            else
            {
                MessageBox.Show($"Uspješno dodan član {noviClan.Ime}, {noviClan.Prezime} sa korisničkim podacima: {noviClan.KorisnickoIme}, {noviClan.Lozinka}");
            }
        }

        private void OcistiFormu()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            bool ispravno = ProvjeriIspravnost();
            if (!ispravno) return;

            var ime = tbIme.Text;
            var prezime = tbPrezime.Text;
            var clan = Knjiznica.DodajClana(ime, prezime);

            PrikaziRezultat(clan);
            OcistiFormu();
        }
    }
}
