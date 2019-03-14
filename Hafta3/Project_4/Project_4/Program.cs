using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Koro koromuz = new Koro();
            //
            Insan i1 = new Insan();
            koromuz.solistEkle(i1);
            //
            Insan i2 = new Insan();
            koromuz.solistEkle(i2);
            //
            Kedi k1 = new Kedi();
            koromuz.solistEkle(k1);
            //
            Kus k2 = new Kus();
            koromuz.solistEkle(k2);
            //
            koromuz.koroSoylesin();

            DansToplulugu dt = new DansToplulugu();
            Kopek k3 = new Kopek();
            dt.dansciEkle(k3);
            Kopek k4 = new Kopek();
            dt.dansciEkle(k4);

            dt.dansGosterisiBaslasin();
        }
    }
}
