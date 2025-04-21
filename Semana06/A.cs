using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06
{
    public abstract class A
    {
        public virtual void MetodoA()
        {
            Console.WriteLine("Hago un cambio");
        }

        // método abstracto no tiene cuerpo
        public abstract void MetodoB();
    }
}
