using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public int Edad
        {
            get { return edad; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Persona(string nombre,  string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nApellido: " + this.Apellido);
			sb.Append("\nNombre: : " + this.Nombre);
			sb.Append("\nEdad: : " + this.edad);
			sb.Append("\nDni: : " + this.dni);

			return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        

        




    }
}
