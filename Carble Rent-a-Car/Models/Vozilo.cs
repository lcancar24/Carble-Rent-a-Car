using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carble_Rent_a_Car.Models
{
    public enum KategorijaVozila
    {
        OsobnoVozilo = 1,
        PutnickiKombi = 2,
        TeretniKombi = 3,
        Limuzina = 4
    }
    public enum VrstaGoriva
    {
        Diesel,
        Benzin
    }

    public class Vozilo
    {
        public int Id { get; set; }


        public string Marka { get; set; }
        public string Naziv { get; set; } 
        public string BrojRegistracije { get; set; }
        public int GodisteVozila { get; set; }
        public DateTime DatumPosljednjeRegistracije { get; set; }

        public int PocetnoStanjeKilometara { get; set; }
        public int TrenutnoStanjeKilometara { get; set; } 
        public double ProsjecnaPotrosnja { get; set; } 
        public VrstaGoriva Gorivo { get; set; }
        public KategorijaVozila Kategorija { get; set; }
        public decimal CijenaNajmaPoSatu { get; set; }
        public decimal CijenaNajmaPoDanu { get; set; }
        public string OpisUocenihOstecenja { get; set; }
        public bool JeNaServisu { get; set; }

        public Vozilo()
        {
            OpisUocenihOstecenja = "Nema oštećenja";
            JeNaServisu = false;
        }
        public decimal DohvatiCijenuServisa()
        {
            switch (Kategorija)
            {
                case KategorijaVozila.OsobnoVozilo: return 300;
                case KategorijaVozila.PutnickiKombi: return 550;
                case KategorijaVozila.TeretniKombi: return 475;
                case KategorijaVozila.Limuzina: return 950;
                default: return 0;
            }
        }

        public override string ToString()
        {
            return $"{Marka} {Naziv} [{BrojRegistracije}]";
        }
    }
}