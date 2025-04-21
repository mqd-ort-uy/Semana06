using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06
{
    public class D : A
    {
        public override void MetodoB()
        {
            Console.WriteLine("Soy el metodo B implementado en clase D");
        }

        public void SoloD()
        {
            Console.WriteLine("Soy un metodo exclusivo de la clase D");
        }
    }
}
