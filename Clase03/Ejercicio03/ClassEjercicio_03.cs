using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ClassEjercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int numero;
            string aux;

            System.Console.WriteLine("Ingrese Numero: ");
            aux = System.Console.ReadLine();
            numero = Int16.Parse(aux);

            for(int i = 2; i <= numero; i++)
            {
                if(i != 2 && i != 3)
                {
                    if(1 % 2 != 0 && i % 3 != 0)
                    {
                        Console.Write(i);
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            System.Console.ReadKey();
        }
    }
}
