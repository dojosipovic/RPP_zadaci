using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopisZadataka
{
    internal static class ZadatakRepozitorij
    {
        public static List<Zadatak> Zadaci = new List<Zadatak>();
        public static List<Zadatak> DohvatiZadatke()
        {
            return Zadaci;
        }
        public static void DodajZadatak(string naziv, DateTime rok)
        {
            Zadaci.Add(new Zadatak(naziv, rok));
            Console.WriteLine(Zadaci.Count);
        }

        public static void ObojiPrikaz(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var zadatak = row.DataBoundItem as Zadatak;
                double brojDana = (DateTime.Now - zadatak.Rok).Days;
                if (brojDana < 1)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
    }
}
