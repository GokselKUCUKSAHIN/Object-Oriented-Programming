using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Ogrenci2
    {
        private int dy;
        private int y;
        public void Goksel()
        {
            Console.WriteLine("hello world");
        }

        public int dYili
        {
            set
            {
                if ((value < 1900) || (value > DateTime.Now.Year))
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    dy = value;
                }
            }
            get
            {
                return dy;
            }
        }
        public int yas
        {
            get
            {
                return DateTime.Now.Year - dy;
            }
        }
    }
}
