using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { -3, 5, 1, 0, 10, -20, 5, 0 };
            Array.Sort(dizi);
            Console.WriteLine("Siralama Sonrası");
            foreach (int item in dizi)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");//sep

            string[] Sdizi = new string[] {"Ali", "Ayşe", "Fatma","Mehmet","Hatice", "Deniz", "Göksel"};
            Array.Sort(Sdizi);
            Console.WriteLine("Siralama Sonrası");
            foreach (string item in Sdizi)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");//sep

            Personel[] Ekip = new Personel[4];
            Ekip[0] = new Personel(42, "Göksel", "Küçükşahin");
            Ekip[1] = new Personel(18,"Ali","Demir");
            Ekip[2] = new Personel(36, "Fatma", "Deniz");
            Ekip[3] = new Personel(7, "Mehmet", "Yılmaz");

            Console.WriteLine("Siralama Once");
            foreach (Personel item in Ekip)
            {
                item.BilgiYaz();
            }

            Console.WriteLine();//sep

            Array.Sort(Ekip);

            Console.WriteLine("Siralama Sonrasi");
            foreach (Personel item in Ekip)
            {
                item.BilgiYaz();
            }
        }
    }
}
