using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Varlik v1 = new Varlik();
            v1.yuru();
            Kedi k1 = new Kedi();
            k1.yuru();
            k1.sesVer();     
        }
    }
}
