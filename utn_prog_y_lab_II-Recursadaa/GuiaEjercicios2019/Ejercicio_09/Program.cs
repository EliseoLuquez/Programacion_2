using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";

            int altura;
            string dato;
            string piramide= "*";
            bool booleanoAltura = false;

            do
            {
                Console.WriteLine("Ingrese la altura de la piramide: ");
                dato = Console.ReadLine();
                booleanoAltura = Int32.TryParse(dato, out altura);

            } while (!booleanoAltura);

            for (int i = 1; i <= altura; i++)
            {
                for (int k = 0; k < (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
