using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class ClassEjercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numero;
            string aux;
            string formato = "{0,10:#,###.00}";
            int maximo = 0;
            int minimo = 0;
            double promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Ingrese Numero: ");
                aux = System.Console.ReadLine();
                numero = Int16.Parse(aux);
                if(i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
                promedio += numero;
            }
            System.Console.WriteLine("El valor Maximo es: " + maximo);
            System.Console.WriteLine("El valor Minimo es: " + minimo);
            System.Console.Write("El valor Promedio es: ");
            System.Console.WriteLine(formato, (promedio/5));
            System.Console.ReadKey();
        }
    }
}
