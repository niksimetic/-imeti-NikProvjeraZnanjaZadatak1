using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠimetićNikProvjeraZnanjaZadatak1
{
    class Program
    {
        static void Main(string[] args)

        {
            int x = 20;
            int y=3;
            double d1;
            double d2;
            d1 = x / y;
            d2 = x % y;
            Console.WriteLine("D1 je:" + d1); 
            Console.WriteLine("D2 je:" + d2);
            Console.ReadKey();
        }
    }
}
