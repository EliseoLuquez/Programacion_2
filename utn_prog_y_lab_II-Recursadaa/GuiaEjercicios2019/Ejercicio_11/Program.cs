using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            string dato;
            int numero;
            int acumulador = 0;
            bool boolDato = false;
            bool validar = false;
            int min = 100;
            int max = -100;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese numero entero Nro {0}: ", i);
                    dato = Console.ReadLine();
                    boolDato = Int32.TryParse(dato, out numero);
                    validar = Validacion.Validar(numero, -100, 100);
                    acumulador += numero;
                    if(numero < min && validar)
                    {
                        min = numero;
                    }
                    else if(numero > max && validar)
                    {
                        max = numero;
                    }

                } while (!boolDato);
            }
            promedio = (acumulador / 10);
            Console.WriteLine("Valor Minimo: {0}", min);
            Console.WriteLine("Valor Maximo: {0}", max);
            Console.WriteLine("Promedio : {0}", promedio);
            Console.ReadKey();
        }
    }
}
