using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_09_02
{
    public interface Observer
    {
        void update(string pujaOferta);
    }

    public class Cliente1 : Observer
    {
        public string puja;
        private Laptop cosa;
        int numCliente = 0;

        public Cliente1(Laptop interes, int numC)
        {
            this.cosa = interes;
            cosa.register(this);
            puja = "100";
            numCliente = numC;
        }
        public void update(string pujaOferta)
        {
            puja = pujaOferta;
            enviarMail();
            
        }
        public void enviarMail()
        {
            Console.WriteLine("El usuario num " + numCliente + "Ha hecho una puja por: " + puja);
        }
    }

    public class Cliente2 : Observer
    {
        private string puja;
        private Laptop cosa;
        int numCliente = 0;

        public Cliente2(Laptop interes, int numC)
        {
            this.cosa = interes;
            cosa.register(this);
            puja = "5000";
            numCliente = numC;
        }
        public void update(string pujaOferta)
        {
            puja = pujaOferta;

        }
        public void enviarMail()
        {
            Console.WriteLine("El usuario num " + numCliente + "Ha hecho una puja por: " + puja);
        }
    }
}
