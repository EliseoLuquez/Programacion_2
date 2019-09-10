using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            int numero;
            int contador = 0;
            int resto;
            bool booleano = false;
            string dato;

            Console.WriteLine("Ingrese numero: ");
            dato = Console.ReadLine();
            booleano = Int32.TryParse(dato, out numero);
            if (booleano)
            {
                for(int i = 1; i <= numero; i++)
                {
                    contador = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (j <= i)
                        {
                            resto = i % j;//Divido i sobre j ej: 1/1, 2/1, 2/2, 3/1, 3/2, 3/3...
                           // Console.WriteLine("Resto: {0}", resto);
                            if(resto == 0)
                            {
                                contador++;
                            }
                        }
                    }  
                    if(contador <= 2)
                    {
                        Console.WriteLine("Numero Primo: {0}", i);
                        contador = 0;
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
