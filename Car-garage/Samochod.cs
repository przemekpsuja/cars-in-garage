using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_garage
{
    class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int iloscSamochodow = 0;

        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
            iloscSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            this.marka = marka_;
            this.model = model_;
            this.iloscDrzwi = iloscDrzwi_;
            this.pojemnoscSilnika = pojemnoscSilnika_;
            this.srednieSpalanie = srednieSpalanie_;
            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return dlugoscTrasy * srednieSpalanie / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka + "\nModel: " + model + "\nIlość drzwi: " + iloscDrzwi + "\nPojemność silnika: " +
                pojemnoscSilnika + "\nŚrednie spalanie: " + srednieSpalanie + "L/100km\n");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Wyprodukowanych samochodów: " + iloscSamochodow + "\n");
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { marka = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }
    }
}
