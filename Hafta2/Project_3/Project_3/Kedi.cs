using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Kedi : Varlik
    {
        public string turu;
        public void ipleOyna()
        {
            Console.WriteLine("Kedi iple oynuyor.");
        }
        public new void yuru()
        {
            Console.WriteLine("Kedi gibi yürüyorum.");
        }
        public new void sesVer()
        {
            Console.WriteLine("Kedi gibi ses veriyorum.");
        }
        //public void override sesVer()

        
    }
}
