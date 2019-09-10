using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            int numero;
            string dato;
            bool booleano = false;
            bool validador = false;

            do
            {
                Console.WriteLine("Ingrese Numero: ");
                dato = Console.ReadLine();
                booleano = Int32.TryParse(dato, out numero);

            } while (!booleano);

            if (booleano)
            {
                for (int i = 1; i < numero; i++)
                {
                    //Formula del centro numerico 2m^2= n^2+n
                    if ((2 * (Math.Pow(i, 2)) == ((Math.Pow(numero, 2)) + numero)))
                    {
                        Console.WriteLine("Entre 1 y {0}", numero);
                        Console.WriteLine("El Centro Numerico es: {0}", i);
                        validador = true;
                    }
                }
                if (!validador)
                {
                    Console.WriteLine("No hay centro numerico entre 1 y {0}", numero);
                }

            }

            Console.ReadKey();
        }
    }
}
