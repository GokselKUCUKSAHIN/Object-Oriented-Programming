using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class DiziIslemleri<T>
    {
        T[] dizi = new T[10];
        int eklenen = 0;
        public void elemanEkle(T a)
        {
            dizi[eklenen++] = a;
        }
        public T elemanDonder(int indis)
        {
            return dizi[indis];
        }
    }
}
