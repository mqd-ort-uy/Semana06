using System.Reflection;

namespace Semana06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //A unA = new A();

            //A unA = new A();
            B unB = new B();
            C unC = new C();
            A unD = new D();

            //unA.MetodoB();
            unB.MetodoB();
            unC.MetodoB();
            unD.MetodoB();
            Console.WriteLine(unD.GetType());
            D unDQueSiEsD = (D)unD;
            Console.WriteLine(unDQueSiEsD.GetType());

            ((D)unD).SoloD();
            unDQueSiEsD.SoloD();

        }
    }
}
