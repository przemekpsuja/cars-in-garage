using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_garage
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private static int iloscSamochodow = 0;
        private string[] samochody;

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko, string adresZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adresZamieszkania = adresZamieszkania;
            samochody = new string[3];
        }

        public void DodajSamochod(string nrRejestracyjny)
        {
            iloscSamochodow++;
            if (iloscSamochodow < 4)
            {
                if (samochody[iloscSamochodow - 1] == null)
                {
                    samochody[iloscSamochodow - 1] = nrRejestracyjny;

                    Console.WriteLine("Dodano samochód o nr rej: {0}", nrRejestracyjny);
                }
            }
            else
            {
                Console.WriteLine("Nie możesz mieć więcej samochodów!!!");
            }



        }


        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }
        public int IloscSamochodow
        {
            get { return iloscSamochodow; }
            set { iloscSamochodow = value; }
        }
        public string[] Samochody
        {
            get { return samochody; }
            set { samochody = value; }
        }


    }
}