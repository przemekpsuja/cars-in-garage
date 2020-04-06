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
            this.IloscSamochodow = 0;
            this.samochody = new string[3];
        }

        public void DodajSamochod(string nrRejestracyjny) 
        {
            if (iloscSamochodow <= 2 && iloscSamochodow >= 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (samochody[i] == null)
                    {
                        samochody[i] = nrRejestracyjny;
                        iloscSamochodow++;
                        Console.WriteLine("Osoba kupiła samochód o nr rej.: {0}", nrRejestracyjny);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Masz maksymalną ilość samochodów! Nie możesz kupić auta o nr rej.: {0}", nrRejestracyjny);
            }
        }

        public void UsunSamochod(string nrRejestracyjny)
        {
            for (int i = 0; i < samochody.Length; i++) 
            {
                if (!String.IsNullOrEmpty(samochody[i]) && samochody[i].Equals(nrRejestracyjny))
                {
                    samochody[i] = null;
                    iloscSamochodow--;
                    Console.WriteLine("Osoba sprzedała auto {0}", nrRejestracyjny);
                    break;
                }
                else if (i == 2 && !string.IsNullOrEmpty(samochody[i]) && !samochody[i].Equals(nrRejestracyjny))
                {
                    Console.WriteLine("Ta osoba nie ma auta z tym nr rej.: {0}", nrRejestracyjny);
                }
            }
        }
    
        public void WypiszInfo()
        {
            Console.WriteLine("Osoba: " + imie + " " + nazwisko + "\nZamieszkała: " + adresZamieszkania + "\nJest właścicielem: ");
            for (int i = 0; i < samochody.Length; i++)
            {
                if (samochody[i] != null)
                {
                    Console.WriteLine(samochody[i].ToString());
                }
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