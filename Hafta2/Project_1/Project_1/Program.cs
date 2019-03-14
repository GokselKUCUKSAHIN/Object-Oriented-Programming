using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kesir k1 = new Kesir();
            k1.pay = 9;
            k1.payda = 4;
            //
            Kesir k2 = new Kesir();
            k2.pay = 4;
            k2.payda = 8;
            //
            Kesir k3 = new Kesir();
            k3.pay = 3;
            k3.payda = 5;
            k3 = k1;
            //
            if (k1 == k2)
            {
                Console.WriteLine("Kesirler Eşit");
            }
            else
            {
                Console.WriteLine("Kesirler Eşit değil");
            }
            //
            if (k1 == k3)
            {
                Console.WriteLine("Kesirler Eşit");
            }
            else
            {
                Console.WriteLine("Kesirler Eşit değil");
            }
            //
            if (k1 > k2)
            {
                Console.WriteLine("k1 büyük");
            }
            else if ( k1 == k2)
            {
                Console.WriteLine("eşit");
            }
            else
            {
                Console.WriteLine("k1 küçük");
            }
            //
            Kesir k4 = k3 + k1;
            k4.Yaz();
            //
            double b = 5.4;
            int a = (int)b;
            Kesir k5 = 3;
            int c = (int)k3;
            //
            Console.WriteLine(c);
            //
            double d = (double)k2;
            //
            Kesir k6 = (Kesir)5.4;
            k6.Yaz();
            //

        }
    }
}