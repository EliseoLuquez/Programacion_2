using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int anioUno;
            int anioDos;
            int resto;
            int restoDos;
            string dato;
            bool booleanoUno = false;
            bool booleanoDos = false;

            do
            {
                Console.WriteLine("Ingrese Año: ");
                dato = Console.ReadLine();
                booleanoUno = Int32.TryParse(dato, out anioUno);
                Console.WriteLine("Ingrese Año: ");
                dato = Console.ReadLine();
                booleanoDos = Int32.TryParse(dato, out anioDos);

            } while(!booleanoUno && !booleanoDos);

            if(booleanoUno && booleanoDos)
            {
                for(int i = anioUno; i <= anioDos; i++)
                {
                    resto = i % 4;
                    restoDos = i % 400;
                    if(resto == 0)
                    {
                        if(i.ToString().ElementAt(2) == '0' && i.ToString().ElementAt(3) == '0' &&  restoDos != 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Año Bisiesto {0}", i);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
