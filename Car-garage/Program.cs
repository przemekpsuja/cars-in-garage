using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Audi", "A4", 5, 1987, 4.75);
            Samochod s2 = new Samochod("BMW", "335D", 4, 3021, 13.24);
            Samochod s3 = new Samochod("Fiat", "Uno", 3, 1101, 4.86);
            Samochod s4 = new Samochod("Peugeot", "407", 5, 1798, 10.22);
            Samochod s5 = new Samochod();

            s1.WypiszInfo();
            Console.WriteLine("Koszt przejazdu 100 km to {0} złotych.\n", s1.ObliczKosztPrzejazdu(100, 4.25));
            s2.WypiszInfo();
            Console.WriteLine("Koszt przejazdu 100 km to {0} złotych.\n", s2.ObliczKosztPrzejazdu(100, 4.25));
            s3.WypiszInfo();
            Console.WriteLine("Koszt przejazdu 100 km to {0} złotych.\n", s3.ObliczKosztPrzejazdu(100, 4.25));
            s4.WypiszInfo();
            Console.WriteLine("Koszt przejazdu 100 km to {0} złotych.\n", s4.ObliczKosztPrzejazdu(100, 4.25));
            s5.WypiszInfo();
            Console.WriteLine("Koszt przejazdu 100 km to {0} złotych.\n", s5.ObliczKosztPrzejazdu(100, 4.25));


            Samochod.WypiszIloscSamochodow();

            Garaz g = new Garaz("Gdańsk", 3);
            g.WprowadzAuto(s1);
            g.WprowadzAuto(s2);
            g.WprowadzAuto(s3);
            g.WprowadzAuto(s4);

            g.WyprowadzSamochod();
            g.WyprowadzSamochod();
            g.WyprowadzSamochod();
            g.WyprowadzSamochod();

            Console.ReadLine();
        }
    }
}
