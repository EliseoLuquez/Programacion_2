using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int numero;
            string dato;
            bool booleano = false;
            int maximo = Int32.MinValue; 
            int minimo = Int32.MaxValue;
            int acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                dato = Console.ReadLine();
                booleano =  Int32.TryParse(dato, out numero);
                if (booleano)
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
                acumulador += numero;
            }

            Console.WriteLine("Maximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0}", (acumulador / 5));
            Console.ReadKey();
        }
    }
}
