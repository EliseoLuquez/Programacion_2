using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false; ;

            return valor <= max && valor >= min ? retorno = true : retorno; 
        }
    }
}
