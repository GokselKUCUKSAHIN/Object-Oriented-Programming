using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uyg3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=new int();
            bool b = new bool();
            //Console.WriteLine(b);

            Zaman z1 = new Zaman();
            //z1.zamaniYaz();

            Zaman z2 = new Zaman(3, 3, 2006);
            Zaman z3 = new Zaman();
        }
    }
}
