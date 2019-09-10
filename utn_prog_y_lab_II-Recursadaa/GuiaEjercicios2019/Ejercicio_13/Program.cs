using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            double numero;
            string dato;
            bool conversorEntero = false;

            do
            {
                Console.WriteLine("Ingrese Numero a Convertir en Binario");
                dato = Console.ReadLine();
                conversorEntero = double.TryParse(dato, out numero);
            } while(!conversorEntero);

            Console.WriteLine("Numero en Binario: ");
            Console.WriteLine(Conversor.DecimalBinario(numero));
            Console.WriteLine("Numero en Decimal: ");
            Console.WriteLine(Conversor.BinarioDecimal(Conversor.DecimalBinario(numero)));
            Console.Read();
        }
    }
}
