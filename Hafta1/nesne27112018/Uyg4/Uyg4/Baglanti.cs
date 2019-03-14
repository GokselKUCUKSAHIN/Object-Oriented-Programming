using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg4
{
    class Baglanti
    {
        static Baglanti b;
        private Baglanti()
        { 
        
        }

        static Baglanti()
        { 
        b=new Baglanti();
        }

        public static Baglanti BaglantiDonder()
        {
            return b;
        }
    }
}
