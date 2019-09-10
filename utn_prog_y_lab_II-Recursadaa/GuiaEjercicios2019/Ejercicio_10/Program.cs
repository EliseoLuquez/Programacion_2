using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int altura;
            int distancia;
            string dato;
            string piramide = "*";
            string espacio = " ";
            bool booleanoAltura = false;

            do
            {
                Console.WriteLine("Ingrese la altura de la piramide: ");
                dato = Console.ReadLine();
                booleanoAltura = Int32.TryParse(dato, out altura);

            } while (!booleanoAltura);

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 0; j < altura - i; j++)
                {
                   Console.Write(" ");
                }
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
