using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class DansToplulugu
    {
        DansEdebilenler[] danscilar = new DansEdebilenler[10];
        int eklenen = 0;
        public void dansciEkle(DansEdebilenler d)
        {
            danscilar[eklenen++] = d;
        }
        public void dansGosterisiBaslasin()
        {
            for (int i = 0; i < eklenen; i++)
            {
                danscilar[i].DonusYap();
                danscilar[i].Zipla();
            }
        }
    }
}
