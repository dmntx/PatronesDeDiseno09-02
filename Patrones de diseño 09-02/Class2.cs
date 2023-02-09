using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseño_09_02
{
    public interface Subject
    {
        void register(Observer o);
        void remove(Observer o);
        void notify();
    }

    public class Laptop : Subject
    {
        private Observer[] clientes;
        private int nPuja;
        private string cosa;

        public Laptop(string cosa)
        {
            clientes = new Observer[10];
            this.cosa = cosa;
        }
        public void notify()
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    clientes[i].update(cosa);
                }
            }
        }

        public void remove(Observer o)
        {
            for(int i = 0; i<clientes.Length; i++)
            {
                if(clientes[i] == o)
                {
                    clientes[i] = null;
                    return;
                }
            }
        }

        public void register(Observer o)
        {
            for(int i = 0; i < clientes.Length; i++)
            {
                if(clientes[i] == null)
                {
                    clientes[i] = o;
                    return;
                }
            }
        }

        public void nuevaPuja()
        {
            notify();
        }

        public void setCosa(string subasta)
        {
            this.cosa = subasta;
            nuevaPuja();
        }
    }
}
