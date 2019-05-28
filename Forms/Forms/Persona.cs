using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string numTarjeta;
        /*
        public Persona(string nombre, string apellido, string dni, string numTarjeta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numTarjeta = numTarjeta;

        }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Apellido: " + apellido);
            sb.AppendLine("Dni: " + dni);
            sb.AppendLine("Nº Tarjeta: " + numTarjeta);

            return sb.ToString();
        }
    }
}
