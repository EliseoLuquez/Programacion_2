using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string aux;
            aux = ValidarOperador(operador);
            double restultado = 0;
            switch (operador)
            {
                case "+":
                    restultado = (num1 + num2);
                    break;
                case "-":
                    restultado = (num1 - num2);
                    break;
                case "*":
                    restultado = (num1 * num2);
                    break; 
                case "/":
                    restultado = (num1 / num2);
                    break;
            }
            return restultado;
        }

        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default :
                    return "+";
            }
        }
    }
}
