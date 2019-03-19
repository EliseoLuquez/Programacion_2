using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacio2
{
    class Program
    {
        static double resultado;
        static int opcion;
        static int num1;
        static int num2;
        static int numero = 1;
        static bool booleano;
        static string mensaje = "No se escucha!!!";
        static string aux;




        static void Main(string[] args)
        {/*
            // CTRL+K+D ORDENA EL CODIGO 
            if (int.TryParse(mensaje, out numero))
            {
                System.Console.WriteLine(mensaje + " " + numero);
                System.Console.ReadKey();

            }
            else
            {
                System.Console.WriteLine("Error ");
                System.Console.ReadKey();
            }
            */

            System.Console.WriteLine("Ingrese un numero: ");
            aux = System.Console.ReadLine();
            num1 = Int16.Parse(aux);
            System.Console.WriteLine("Ingrese un numero: ");
            aux = System.Console.ReadLine();
            num2 = Int16.Parse(aux);
            System.Console.WriteLine("Elija Operacion: ");
            System.Console.WriteLine("1. Suma");
            System.Console.WriteLine("2. Resta");
            System.Console.WriteLine("3. Multiplicacion");
            System.Console.WriteLine("4. Division");
            System.Console.WriteLine("5. Salir");
            aux = System.Console.ReadLine();
            opcion = Int16.Parse(aux);
            miSwitch(num1, num2, opcion);

            System.Console.ReadKey();

        }

        static void miSwitch(int num1, int num2, int opcion)
        {
          
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    System.Console.WriteLine("El Resultado es: " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    System.Console.WriteLine("El Resultado es: " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    System.Console.WriteLine("El Resultado es: " + resultado);
                    break;
                case 4:
                    if(num2 == 0)
                    {
                        System.Console.WriteLine("No se puede dividir por 0");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        System.Console.WriteLine("El Resultado es: " + resultado);
                    }
                    break;
                case 5:
                    opcion = 0;
                    break;
            }

          
            
        }
        





    }
}
