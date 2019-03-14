using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DiziIslemleri<int> dI = new DiziIslemleri<int>();
            DiziIslemleri<string> dS = new DiziIslemleri<string>();
            DiziIslemleri<Kitap> dK = new DiziIslemleri<Kitap>();
            dK.elemanEkle(new Kitap(1, "1984", "George Orwell"));
            dK.elemanEkle(new Kitap(3, "Mada", "Genji"));
        }
    }
}
