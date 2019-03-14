using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap();
            k1.kitapAdi = "Sefiller";
            k1.yazari = "Victor Hugo";
            k1.oduncVer();

            Kitap k2 = new Kitap();
            k2.kitapAdi = "Alamut Kalesi";
            k2.yazari = "Vladimir Batrol";
            k2.oduncVer();

            Kitap k3 = new Kitap();
            k3.kitapAdi = "ucurtma avcisi";
            k3.yazari = "Khalid Husseini";
            k3.oduncVer();

            Kitap k4 = new Kitap();
            k4.yazari = "Canan Tan";
            k4.kitapAdi = "Yüreğim Seni Çok Sevdi";
            k4.oduncVer();

            Kitap k5 = new Kitap();
            k5.kitapAdi = "Anne Kafamda Bit Var";
            k5.yazari = "Tarık Akan";
            k5.oduncVer();

            Kitap.statikMetot();

        }
    }
}
