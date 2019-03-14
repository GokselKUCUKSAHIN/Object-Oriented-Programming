using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Kopek : DansEdebilenler
    {
        public override void Zipla()
        {
            Console.WriteLine("Dört Ayak üzerinde zıpladı.");
        }
        public override void DonusYap()
        {
            Console.WriteLine("Dört Ayak üzerinde dönüş yap.");
        }
    }
}
