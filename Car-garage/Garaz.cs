using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_garage
{
    class Garaz
    {
        private string adres;
        private int pojemnoscGarazu;
        private int liczbaZaparkowanychSamochodow = 0;
        private Samochod[] listaSamochodow;

        public Garaz()
        {
            adres = "nieznany";
            pojemnoscGarazu = 0;
            liczbaZaparkowanychSamochodow = 0;
            listaSamochodow = null;
        }

        public Garaz(string adres_, int pojemnoscGarazu_)
        {
            this.adres = adres_;
            this.pojemnoscGarazu = pojemnoscGarazu_;
            this.listaSamochodow = new Samochod[pojemnoscGarazu_];
        }

        public void WprowadzAuto(Samochod s)
        {
            if (listaSamochodow[pojemnoscGarazu - 1] == null)
            {
                for (int i = 0; i < pojemnoscGarazu; i++)
                {
                    if (listaSamochodow[i] == null)
                    {
                        listaSamochodow[i] = s;
                        liczbaZaparkowanychSamochodow++;
                        Console.WriteLine("Samochód {0} {1} został wstawiony do garażu", s.Marka, s.Model);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Garaż jest pełny. Nie można zaparkować {0} {1}\n", s.Marka, s.Model);
            }
        }

        public Samochod WyprowadzSamochod()
        { 
            Samochod usunietySamochod = null;

            if (liczbaZaparkowanychSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
            }
            else
            {
                int indexDoUsuniecia = liczbaZaparkowanychSamochodow - 1;
                usunietySamochod = listaSamochodow[indexDoUsuniecia];
                listaSamochodow[indexDoUsuniecia] = null;
                Console.WriteLine("Wyprowadzono {0} {1}.", usunietySamochod.Marka, usunietySamochod.Model);
                liczbaZaparkowanychSamochodow--;

            }
            return usunietySamochod;
        }

        public void WypiszInfo()
        {
            for (int i = 0; i < liczbaZaparkowanychSamochodow; i++)
            {
                listaSamochodow[i].WypiszInfo();
            }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int PojemnoscGarazu
        {
            get { return pojemnoscGarazu; }
            set
            {
                pojemnoscGarazu = value;
                listaSamochodow = new Samochod[pojemnoscGarazu];
            }
        }

        public int LiczbaZaparkowanychSamochodow
        {
            get { return liczbaZaparkowanychSamochodow; }
            set { liczbaZaparkowanychSamochodow++; }
        }

        public Samochod[] ListaSamochodow
        {
            get { return listaSamochodow; }
            set { listaSamochodow = value; }
        }
    }
}

