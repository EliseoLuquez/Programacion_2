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
            sb.AppendFormat("\nApellido: {0} \nDni: {1} \nEdad: {2} \nNombre: {3}", this.Apellido, this.Dni, this.Edad, this.Nombre);

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        

        




    }
}
