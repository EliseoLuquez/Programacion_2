using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            int numero = 10000;
            int resto;
            int acumulador = 0;

            for(int i = 1; i < numero; i++)
            {
                acumulador = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (j < i)
                    {
                        resto = i % j;//Divido i sobre j ej: 1/1, 2/1, 2/2, 3/1, 3/2, 3/3...
                        // Console.WriteLine("Resto: {0}", resto);
                        if (resto == 0)
                        {
                            acumulador += j;
                        }
                    }
                    if(i == acumulador && j == i)
                    {
                        Console.WriteLine("Numero Perfecto: {0}", i);
                        acumulador = 0;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
