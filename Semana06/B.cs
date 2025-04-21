using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana06
{
    public class B : A
    {
        public override void MetodoA()
        {
            Console.WriteLine("Soy el metodo A implementado por la clase B");
        }

        public override void MetodoB()
        {
            Console.WriteLine("Soy el metodo B implementado por la clase B");
        }
    }
}
