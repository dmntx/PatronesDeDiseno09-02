using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_09_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Alienware");
            Cliente1 cliente1 = new Cliente1(laptop, 1);
            Cliente1 cliente2 = new Cliente1(laptop, 2);
            /*laptop.register(cliente1);
            laptop.register(cliente2);*/
            laptop.setCosa("Alienware");
            //laptop.notify();
            Console.ReadKey();
        }
    }
}
