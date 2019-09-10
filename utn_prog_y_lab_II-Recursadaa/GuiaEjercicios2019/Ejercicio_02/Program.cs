using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numero;
            string dato;
            bool booleano = false;

            Console.WriteLine("Ingrese nuumero: ");
            dato = Console.ReadLine();
            booleano = Int32.TryParse(dato, out numero);
            if (booleano)
            {
                Console.WriteLine("Numero ingresado: {0}", numero);
                Console.WriteLine("Cuadrado del numero: {0}", Math.Pow(numero, 2));
                Console.WriteLine("Cubo del numero: {0}", Math.Pow(numero, 3));
            }
            Console.ReadKey(); 
        }
    }
}
