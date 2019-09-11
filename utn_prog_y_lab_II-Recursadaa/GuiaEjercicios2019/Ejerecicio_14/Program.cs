using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double lado;
            double bTriangulo;
            double altura;
            double radio;
            string numero;
            bool ingreso = false;
            string dato;
            string datoDos;

            do
            {
                Console.WriteLine("Calcular Area de: ");
                Console.WriteLine("\n1-Cuadrado \n2-Triangulo\n3-Circulo");
                numero = Console.ReadLine();
                switch (numero)
                {
                    case "1":
                        Console.WriteLine("Ingrese Lado del Cuadrado: ");
                        dato = Console.ReadLine();
                        ingreso = double.TryParse(dato, out lado);
                        Console.WriteLine("El Area del Cuadrado es : {0}", CalculoDeArea.CalcularCuadrado(lado));
                        break;
                    case "2":
                        Console.WriteLine("Ingrese Base del Trinagulo: ");
                        dato = Console.ReadLine();
                        ingreso = double.TryParse(dato, out bTriangulo);
                        Console.WriteLine("Ingrese Altura del Trinagulo: ");
                        datoDos = Console.ReadLine();
                        ingreso = double.TryParse(datoDos, out altura);
                        Console.WriteLine("El Area del Triangulo es : {0}", CalculoDeArea.CalcularTriangulo(bTriangulo, altura));
                        break;
                    case "3":
                        Console.WriteLine("Ingrese Radio del Cuadrado: ");
                        dato = Console.ReadLine();
                        ingreso = double.TryParse(dato, out radio);
                        Console.WriteLine("El Area del Circulo es : {0}", CalculoDeArea.CalcularCirculo(radio));
                        break;
                }
            } while (ingreso);


            Console.ReadKey();
        }
    }
}
