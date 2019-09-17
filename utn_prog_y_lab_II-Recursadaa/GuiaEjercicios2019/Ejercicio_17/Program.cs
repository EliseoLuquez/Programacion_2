using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";

            string escribir;

            Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b1.GetColor(), b1.GetTinta());
            b1.Pintar(-20, out escribir);
            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b1.GetColor(), b1.GetTinta());
            b1.Recargar();
            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b1.GetColor(), b1.GetTinta());

            Console.WriteLine();

            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b2.GetColor(), b2.GetTinta());
            b2.Pintar(-40, out escribir);
            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b2.GetColor(), b2.GetTinta());
            b2.Recargar();
            Console.WriteLine("El Boligrafo es {0} y tiene {1} de tinta", b2.GetColor(), b2.GetTinta());

            Console.ReadKey();
        }
    }
}
