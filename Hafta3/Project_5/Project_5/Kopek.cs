using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Kopek : IDansEdebilenler
    {
        public void Zipla()
        {
            Console.WriteLine("Köpek Dönüş yaptı.");
        }
        public void DonusYap()
        {
            Console.WriteLine("Köpek Dört ayak üzerinde Zıpladı.");
        }
    }
}
