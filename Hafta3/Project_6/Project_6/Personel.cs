using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Personel : IComparable
    {
        public string adi;
        public string soyadi;
        public int sicilNo;

        public Personel(int sn, string a , string s)
        {
            sicilNo = sn;
            adi = a;
            soyadi = s;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("adi: "+adi + " soyadi: "+ soyadi + " sicilNo: " + sicilNo);
        }
        public int CompareTo(object o)
        {
            Personel p = (Personel)o;
            return sicilNo.CompareTo(p.sicilNo);
        }
    }
}
