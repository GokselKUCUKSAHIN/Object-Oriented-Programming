using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Insan : ISesVerebilenler, IDansEdebilenler
    {
        public virtual void sesVer()
        {
            Console.WriteLine("DoReMiFaSolLaSiDo");
        }
        public virtual void DonusYap()
        {
            Console.WriteLine("Insan soldan saga Donus.");
        }
        public virtual void Zipla()
        {
            Console.WriteLine("Tek ayak üstünde zipladı.");
        }
    }
}
