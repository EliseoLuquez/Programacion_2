using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                numero = this.ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en formato double.
        /// Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double numero = 0;
            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return numero;    
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return (n1.numero / n2.numero);
            }
        }

        /*
         * Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado, trabajarán con enteros positivos, 
         * quedándose para esto con el valor absoluto y entero del double recibido:o El método BinarioDecimal convertirá 
         * un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
         * o Ambas opciones del método DecimalBinario convertirán un número decimal a binario, en caso de ser posible. 
         * Caso contrario retornará "Valor inválido". Reutilizar código.
         */
        /// <summary>
        /// Convierte un Numero Binario a Entero
        /// </summary>
        /// <param name="binario"></param>
        public string BinarioDecimal(string binario)
        {
            double valor = 0;
            int tam;
            tam = binario.Length;
            for (int i = 1; i <= tam; i++)
            {
                if (binario[i - 1] == '0' || binario[i - 1] == '1')
                {
                    valor += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, tam - i);
                }
            }
            return valor.ToString();
        }


        /// <summary>
        /// Convierte un Numero Entero a Binario
        /// </summary>
        /// <param name="numero"></param>
        public string DecimalBinario(string numero)
        {
            bool retorno;
            string valor = "";
            string invalido = "Valor Invalido";
            retorno = double.TryParse(numero, out double binario);
            if (retorno)
            {
                do
                {
                    valor = ((int)binario % 2).ToString() + valor;
                    binario = binario / 2;

                } while (binario >= 1);
            }

            return retorno ? valor.ToString() : invalido;
        }

        /// <summary>
        /// Convierte un Numero Entero a Binario
        /// </summary>
        /// <param name="numero"></param>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

    }
}
