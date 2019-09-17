using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej_18_Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";

            Punto p1 = new Punto(10, 10);
            Punto p3 = new Punto(5, 5);

            Rectangulo r1 = new Rectangulo(p1, p3);

            //Console.WriteLine("Area: {0}", r1.Area());
            //Console.WriteLine("Perimetro: {0}", r1.Perimetro());

            Console.WriteLine(r1.Mostrar(r1));
            


            Console.ReadKey();
        }
    }
}
