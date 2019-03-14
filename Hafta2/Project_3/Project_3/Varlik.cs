using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    //Entity
    class Varlik
    {
        public int yas;
        public int agirlik;

        public void yuru()
        {
            Console.WriteLine("Varlik gibi yürüyorum.");
        }
        public void sesVer()
        {
            Console.WriteLine("Varlik gibi ses veriyorum.");
        }
        private int privDegisken;
        private void priMethod()
        {
            Console.WriteLine("Private Method :D");
        }
    }
}
