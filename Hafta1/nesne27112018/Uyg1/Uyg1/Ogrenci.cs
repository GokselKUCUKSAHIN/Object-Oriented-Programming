using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class Ogrenci
    {
        public int ogrNo;
        public string adi;
        public string soyadi;
        int alinanDersSayisi = 0;
        AlinanDers[] dersleri = new AlinanDers[10];

        public bool dersAta(Ders d)
        { 
            AlinanDers ad=new AlinanDers();
            ad.dersAdi=d.dersAdi;
            ad.dersKodu=d.dersKodu;
            ad.kredi=d.kredi;
            bool sonuc = false;
            if (alinanDersSayisi < 10)
            {
                dersleri[alinanDersSayisi] = ad;
                alinanDersSayisi++;
                sonuc = true;
            }
            return sonuc;
        }

        public bool NotGirisi(string dersKodu, int vize, int final)
        {
            bool var = false;
            for (int i = 0; i < alinanDersSayisi; i++)
            {
                if (dersleri[i].dersKodu == dersKodu)
                {
                    var = true;
                    dersleri[i].vize = vize;
                    dersleri[i].final = final;
                }
            }

            return var;
        }

        public double ganoHesapla()
        {
            double gano= 0;
            int krediToplam = 0;
            for (int i = 0; i < alinanDersSayisi; i++)
            { 
            gano+=(dersleri[i].vize*0.4+dersleri[i].final*0.6)*dersleri[i].kredi;
            krediToplam += dersleri[i].kredi;
            }
            gano = gano / krediToplam;
            return gano;
        }

    }
}
