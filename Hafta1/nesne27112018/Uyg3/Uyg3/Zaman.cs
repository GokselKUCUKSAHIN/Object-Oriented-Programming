using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg3
{
    class Zaman
    {
        int gun;
        int ay;
        int yil;

        public Zaman()
        {
            gun = DateTime.Now.Day;
            ay = DateTime.Now.Month;
            yil = DateTime.Now.Year;
            //constructor sinif ismi ile ayni isimdedir
            //bir deger return etmez
            Console.WriteLine("parametresiz constr calisti");
        }

        public Zaman(int g, int a, int y)
        {
            gun = g;
            ay = a;
            yil = y;
            //zamaniYaz();
            Console.WriteLine("parametreli constr calisti");
        }

         static Zaman()
        { 
            //statik constructorlarda erisim seviyesi (public private gibi) belirtilmez
            //statik constructor parametre almaz
            Console.WriteLine("static constr calisti");
             //statik constr. bir defa calisir
             //butun constr.lardan once calisir.
             //nesne turetilmezse calismaz
        
        }
        public void zamaniYaz()
        {
            Console.WriteLine("{0}/{1}/{2}", gun, ay, yil);
        }
    }
}
