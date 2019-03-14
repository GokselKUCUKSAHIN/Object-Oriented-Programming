using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Koro koromuz = new Koro();
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            Kedi k1 = new Kedi();
            Kus k2 = new Kus();
            MahmutTuncer halo = new MahmutTuncer(); //xd
            koromuz.solistEkle(halo);
            koromuz.solistEkle(k1);
            koromuz.solistEkle(i1);
            koromuz.solistEkle(i2);
            koromuz.solistEkle(k2);

            koromuz.koroSoyle();

            DansToplulugu dt = new DansToplulugu();
            Kopek k9 = new Kopek();
            dt.DanciEkle(k9); //xd 2
            Kopek k10 = new Kopek();
            dt.DanciEkle(k10);
            Insan i3 = new Insan();
            dt.DanciEkle(i3);
            dt.DanciEkle(i2);
            dt.DanciEkle(halo);
            dt.DansGosterisiBaslasin();
        }
    }
}

