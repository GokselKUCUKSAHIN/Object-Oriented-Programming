using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class DansToplulugu
    {
        IDansEdebilenler[] danscilar = new IDansEdebilenler[10];
        int eklenen = 0;

        public void DanciEkle(IDansEdebilenler d)
        {
            danscilar[eklenen++] = d;
        }
        public void DansGosterisiBaslasin()
        {
            for (int i = 0; i < eklenen; i++)
            {
                danscilar[i].Zipla();
                danscilar[i].DonusYap();
            }
        }
    }
}
