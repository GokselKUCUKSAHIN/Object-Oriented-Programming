using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Koro
    {
        SesVerebilenler[] sanatcilar = new SesVerebilenler[10];
        int eklenen = 0;
        public void solistEkle(SesVerebilenler a)
        {
            sanatcilar[eklenen++] = a; 
        }
        public void koroSoylesin()
        {
            for (int i = 0; i < eklenen; i++)
            {
                sanatcilar[i].SesVer();
            }
        }
    }
}
