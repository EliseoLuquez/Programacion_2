using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace TP3Consola
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = ValidarNombreApellido(value); ; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido  = ValidarNombreApellido(value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = ValidarDni(this.nacionalidad, value);
            }
        }

        public string StringToDNI
        {
            set
            {
                dni = ValidarDni(this.nacionalidad, value);
            }
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (Nacionalidad == ENacionalidad.Argentino && dni >= 1 && dni <= 89999999)
            {
                dni = dato;
            }
            else if (nacionalidad == ENacionalidad.Extranjero && dni >= 90000000 && dni <= 99999999)
            {
                dni = dato;
            }
            throw new NacionalidadInvalidException();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            string dniAux = dato;
            if (dniAux.Length <= 8)
            {
                dni = Convert.ToInt32(dniAux);
            }
            throw new DniInvalidException();
        }

        private string ValidarNombreApellido(string dato)
        {
            if(Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
            {
                return dato;
            }
            return "";
        }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) :  base()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringToDNI = dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} Apellido: {1} DNI: {2} Nacionalidad: {3}", this.Nombre, this.Apellido, this.DNI, this.nacionalidad);

            return sb.ToString();
        }





    }
}
