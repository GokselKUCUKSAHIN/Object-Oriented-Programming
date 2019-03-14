using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2
{
    class Kitap
    {
        public string kitapAdi;
        public string yazari;
        static int odunckitapsayisi = 0;
        public void oduncVer()
        {
            Console.WriteLine(kitapAdi + " isimli kitap odunc verildi");
            odunckitapsayisi++;
            Console.WriteLine(odunckitapsayisi);
        
        }
        int a = 5;
        public static void statikMetot()
        {
            Console.WriteLine("Ben statik bir metodum");
            Console.WriteLine("nesne ismi ile degil sinif ismi uzerinden cagrilirlar");
            Console.WriteLine("bireysel bazda nesneleri degil genel anlamda butun sinifla ilgili metotlardir");
            //a = 2;
            Console.WriteLine("statik metot icinde non-static degisken kullanilamaz");
            Console.WriteLine(odunckitapsayisi);
            Console.WriteLine("statik degiskenler kullanilabilir");
        
        }


    }
}
