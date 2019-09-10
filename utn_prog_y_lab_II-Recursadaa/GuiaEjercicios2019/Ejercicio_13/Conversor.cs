using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        /// <summary>
        /// Convierte un Numero Entero a Binario
        /// </summary>
        /// <param name="numero"></param>
        public static string DecimalBinario(double numero)
        {
            string valor = "";
            //for (int i = 0; i <= numero; i++)
            do {
                valor = ((int)numero % 2).ToString() + valor;
                
                numero = numero / 2;

            } while (numero >= 1);
            return valor;
        }

        /// <summary>
        /// Convierte un Numero Binario a Entero
        /// </summary>
        /// <param name="binario"></param>
       public static double BinarioDecimal(string binario)
        {
            double valor = 0;
            int tam;
            tam = binario.Length;
            for (int i = 1; i <= tam; i++)
            {
                if(binario[i-1] == '0' || binario[i - 1] == '1')
                {
                    valor += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, tam - i);
                }
            }
            return valor;
        }
    }
}
