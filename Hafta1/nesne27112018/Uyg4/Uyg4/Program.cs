using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Baglanti b1 = new Baglanti();
            //Baglanti b2 = new Baglanti();
            Baglanti b1 = Baglanti.BaglantiDonder();
            Baglanti b2 = Baglanti.BaglantiDonder();

            if (b1 == b2)
                Console.WriteLine("ayni nesneler");
            else
                Console.WriteLine("farkli nesneler");
        }
    }
}
