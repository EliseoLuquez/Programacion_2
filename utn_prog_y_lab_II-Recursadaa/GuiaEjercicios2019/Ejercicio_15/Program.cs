using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            string dato;
            bool ingresoNumero1 = false;
            bool ingresoNumero2 = false;
            double numero1;
            double numero2;
            string operador;
            double resultado = 0;

            do
            {
                Console.WriteLine("Ingrese Numero 1: ");
                dato = Console.ReadLine();
                ingresoNumero1 = double.TryParse(dato, out numero1);

                Console.WriteLine("Ingrese Numero 2: ");
                dato = Console.ReadLine();
                ingresoNumero2 = double.TryParse(dato, out numero2);

                Console.WriteLine("Ingrese Operacion:(+ - * /)");
                operador = Console.ReadLine();

            } while (!ingresoNumero1 && !ingresoNumero2);

            resultado = Calculadora.Calcular(numero1, numero2, operador);
            Console.WriteLine("El resultado es: {0}", resultado);

            Console.ReadKey();
        }
    }
}
