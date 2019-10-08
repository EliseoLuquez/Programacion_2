using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Console.WriteLine("Inicializo 5 Dolares: ");
            Dolar d1 = new Dolar(1, 58);

            Console.WriteLine("Inicializo 10 Euros: ");
            Euro e1 = new Euro(1, 68);

            Console.WriteLine("Inicializo 100 Pesos: ");
            Pesos p1 = new Pesos(1, 1);

            d1 += e1;
            Console.WriteLine("{0}", d1.GetCantidad());






            Console.ReadKey();


        }
    }
}
