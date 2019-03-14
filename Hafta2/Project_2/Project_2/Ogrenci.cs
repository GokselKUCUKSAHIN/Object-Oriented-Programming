using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Ogrenci : Ogrenci2
    {
        public int dyili;
        public int yas;

        public void dYiliAta(int dy)
        {
            if((dy < 1900)||(dy>DateTime.Now.Year))
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                dyili = dy;
                Goksel();
            }
        }
        public int dYiliDonder()
        {
            return dyili;
        }

        public int yasDonder()
        {
            return DateTime.Now.Year - dyili;
        }
    }
}
