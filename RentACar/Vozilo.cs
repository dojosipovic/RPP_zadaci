using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    public class Vozilo
    {
        public string Registracija { get; set; }
        public string Model { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPredavanja { get; set; }
        public string PregledNapravio { get; set; }

        public Vozilo(string registracija, string model)
        {
            Registracija = registracija;
            Model = model;
        }

        public void RezervirajVozilo()
        {
            DatumRezervacije = DateTime.Now;
        }

        public void PredajVozilo()
        {
            DatumPredavanja = DateTime.Now;
        }

        public void PregledajVozilo(string pregledNapravio)
        {
            PregledNapravio = pregledNapravio;
        }

        public void AktivirajVozilo()
        {

        }

        public void DeaktivirajVozilo()
        {

        }

        public void UciniRaspolozivim()
        {

        }
    }
}
