using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Kesir
    {
        public int pay { get; set; } //property
        public int payda;

        public void Yaz()
        {
            Console.WriteLine("{0}/{1}",pay,payda);
        }

        public static bool operator==(Kesir k1, Kesir k2)
        {
            double s1 = (double)k1.pay / (double)k1.payda;
            double s2 = (double)k2.pay / (double)k2.payda;
            if(s1 == s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Kesir k1, Kesir k2)
        {
            return !(k1 == k2);
        }
        public static bool operator >(Kesir k1, Kesir k2)
        {
            double s1 = (double)k1.pay / (double)k1.payda;
            double s2 = (double)k2.pay / (double)k2.payda;
            if(s1 > s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Kesir k1, Kesir k2)
        {
            double s1 = (double)k1.pay / (double)k1.payda;
            double s2 = (double)k2.pay / (double)k2.payda;
            if (s1 < s2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Kesir operator +(Kesir k1, Kesir k2)
        {
            Kesir k3 = new Kesir();
            k3.pay = k1.pay * k2.payda + k2.pay * k1.payda;
            k3.payda = k1.payda * k2.payda;
            return k3;
        }
        public static implicit operator Kesir(int a)
        {
            Kesir sonuc = new Kesir();
            sonuc.pay = a;
            sonuc.payda = 1;
            return sonuc;
        }
        public static explicit operator int(Kesir k1)
        {
            int sonuc = k1.pay / k1.payda;
            return sonuc;
        }
    }
}
