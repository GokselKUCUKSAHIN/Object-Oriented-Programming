using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class OgrenciController
    {

        public Ders DersOlusturCagrisi(string dersKodu,string dersAdi,int kredi)
        {
            Ders d = new Ders();
            d.dersKodu = dersKodu;
            d.dersAdi = dersAdi;
            d.kredi = kredi;
            return d;

        }

        public Ogrenci OgrenciOlusturCagrisi(int ogrNo, string adi, string soyadi)
        {
            Ogrenci o = new Ogrenci();
            o.ogrNo = ogrNo;
            o.adi = adi;
            o.soyadi = soyadi;
            return o;
        }

        public bool NotGirmeCagrisi(Ogrenci o, string dersKodu, int vize, int final)
        {
            return o.NotGirisi(dersKodu, vize, final);
        }

        public double GanoHesapCagrisi(Ogrenci o)
        {
            return o.ganoHesapla();
        }

        public bool dersAtamaCagrisi(Ogrenci o, Ders d)
        {
            return o.dersAta(d);
        }
    }
}
