using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class ClassEjercico_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            int numero;
            int value = 2;
            string aux;
            string formato = "{0,10:#,###.00}";

            System.Console.WriteLine("Ingrese Numero: ");
            aux = System.Console.ReadLine();
            numero = Int16.Parse(aux);

            while (numero < 0)
            {
                System.Console.Write("Error. Reingresar numero!");
                System.Console.WriteLine("Ingrese Numero: ");
                aux = System.Console.ReadLine();
                numero = Int16.Parse(aux);
            }

            System.Console.Write("El cuadrado del numero es: ");
            System.Console.WriteLine(formato,Math.Pow(numero, value));
            System.Console.Write("El cubo del numero es: ");
            value = 3;
            System.Console.WriteLine(formato, Math.Pow(numero, value));

            System.Console.ReadKey();
        }
    }
}
