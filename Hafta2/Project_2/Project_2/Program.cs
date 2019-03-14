using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.dyili = 2008;
            Console.WriteLine(o1.yas);//0
            int a = o1.dYiliDonder();
            int b = o1.yasDonder();
            Console.WriteLine(b);
            //
            Ogrenci2 o2 = new Ogrenci2();
            o2.dYili = 2000;
            int c = o2.dYili;
            Console.WriteLine(c);
            //
            int d = o2.yas;
            Console.WriteLine(d);
          
            //
        }
    }
}
