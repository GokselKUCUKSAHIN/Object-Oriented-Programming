using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Koro 
    {
        ISesVerebilenler[] solistler = new ISesVerebilenler[10];
        int eklenen = 0;

        public void solistEkle(ISesVerebilenler s)
        {
            solistler[eklenen++] = s;
        }
        public void koroSoyle()
        {
            for (int i = 0; i < eklenen; i++)
            {
                solistler[i].sesVer();
            }
        }
    }
}
