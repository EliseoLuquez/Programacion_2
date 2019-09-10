using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int numero;
            int acumulador = 0;
            bool convertirEntero = false;
            string dato;
            char respuesta;

            do
            {
                do
                {
                    Console.WriteLine("\nIngrese Numero: ");
                    dato = Console.ReadLine();
                    convertirEntero = Int32.TryParse(dato, out numero);
                    acumulador += numero;
                    Console.WriteLine("Total: {0}", acumulador);
                    Console.WriteLine("¿Continuar? S/N");
                    respuesta = Console.ReadKey().KeyChar;

                } while (!convertirEntero);
            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.ReadKey();
        }
    }
}
