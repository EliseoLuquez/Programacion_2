using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
            }
            return resultado;
        }

        private static bool Validar(double num2)
        {
            bool retorno = false;
            if (num2 != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
