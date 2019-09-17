using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador();

            Console.WriteLine("Suma: {0}", sum.Sumar(1, 8));
            Console.WriteLine("Suma: {0}", sum.Sumar("12", "34"));
            Console.WriteLine();
            Console.WriteLine("Suma: {0}", sum2.Sumar(6, 8));
            Console.WriteLine("Suma: {0}", sum2.Sumar("56", "78"));
            Console.WriteLine("Cantidad de sumas Sum: {0}", (int)sum);
            Console.WriteLine("Cantidad de sumas Sum2: {0}", (int)sum2);
            Console.WriteLine(sum + sum2);

            Console.ReadKey();
        }
    }
}
