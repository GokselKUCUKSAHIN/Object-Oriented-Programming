using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Kitap
    {
        public int no;
        public string adi;
        public string yazari;

        public Kitap(int n,string a,string y)
        {
            no = n;
            adi = a;
            yazari = y;
        }
        public void KitapYazdir()
        {
            Console.WriteLine("{0} {1} {2}",no,adi,yazari);
        }
    }
}
