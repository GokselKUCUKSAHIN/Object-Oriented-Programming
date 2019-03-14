using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.OgrenciBilgiAl();
            m.OgrenciyeDersAta();
            m.OgrenciyeDersAta();
            m.OgrenciyeDersAta();
            m.NotGirisBilgileriniAl();
            m.NotGirisBilgileriniAl();
            m.NotGirisBilgileriniAl();
            m.GanoYaz();

        }
    }

        public class Menu
        {
            Ogrenci o = new Ogrenci();
            OgrenciController kontroler = new OgrenciController();
            Ders d = new Ders();
        public  void MenuList()
        {
            Console.WriteLine("Ogrenci Bilgi Girisi için->1");
            Console.WriteLine("Ders Tanimi icin->2");
            Console.WriteLine("Ogrenciye Ders Atamak icin->3");
            Console.WriteLine("Ogrenciye not girisi icin->4");
            Console.WriteLine("cikis icin->0");
        
        }



        
        
        public void OgrenciBilgiAl()
        {
            Console.WriteLine("Ogrenci No yaziniz");
            int ogrNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("isim yaziniz");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisim yaziniz");
            string soyisim = Console.ReadLine();
            o = kontroler.OgrenciOlusturCagrisi(ogrNo, isim, soyisim);

            
        }

        public void DersTanimBilgileriAl()
        {
            Console.WriteLine("ders Kodu yaziniz");
            string dersKodu = Console.ReadLine();
            Console.WriteLine("dersAdi yaziniz");
            string dersAdi = Console.ReadLine();
            Console.WriteLine("Kredi yaziniz");
            int kredi = Convert.ToInt32(Console.ReadLine());
            d = kontroler.DersOlusturCagrisi(dersKodu, dersAdi, kredi);
        
        }

        public void OgrenciyeDersAta()
        {
            DersTanimBilgileriAl();
            bool sonuc = kontroler.dersAtamaCagrisi(o, d);
            if (sonuc == true)
                Console.WriteLine("ders atama basarili");
            else
                Console.WriteLine("ders atama basarisiz");
        }
        public void NotGirisBilgileriniAl()
        {
            Console.WriteLine("ders Kodu giriniz");
            string dersKodu = Console.ReadLine();
            Console.WriteLine("Vize?");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final?");
            int final = Convert.ToInt32(Console.ReadLine());
            bool sonuc = kontroler.NotGirmeCagrisi(o, dersKodu, vize, final);
            if (sonuc == true)
                Console.WriteLine("Not girisi basarili");
            else
                Console.WriteLine("Not girisi basarisiz");
           
        
        }

        public void GanoYaz()
        {
            double gano = kontroler.GanoHesapCagrisi(o);
            Console.WriteLine(gano);
        }
    }
}
