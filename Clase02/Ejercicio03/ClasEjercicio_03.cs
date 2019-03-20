using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ClasEjercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int numero;
            int contador = 2;
            bool primo = true;
            string aux;

            System.Console.WriteLine("Ingrese Numero: ");
            aux = System.Console.ReadLine();
            numero = Int16.Parse(aux);

            while((primo) && contador < numero)
            {
                if(numero % contador == 0)
                {         
                    System.Console.WriteLine("Numero: " + contador);
                    /*while(contador % (contador - 1) == 0)
                    {

                    }
                    */
                    contador++;
                }
                else
                {
                    primo = false;
                }
            }
            
            System.Console.ReadKey();
        }
    }
}
