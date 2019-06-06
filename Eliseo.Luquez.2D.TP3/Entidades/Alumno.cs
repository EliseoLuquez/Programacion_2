using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Consola
{
    sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Entidades.Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
            Entidades.Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
            Entidades.Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma) 
        {
            this.estadoCuenta = estadoCuenta;
        }

        public static bool operator ==(Alumno a, Entidades.Universidad.EClases clase)
        {
            // Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.         
            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Alumno a, Entidades.Universidad.EClases clase)
        {
            // Un Alumno será distinto a un EClase sólo si no toma esa clase.
            return !(a.claseQueToma == clase);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendFormat("Clase que toma: {0}  Estado de Cuenta: {1}", this.claseQueToma, this.estadoCuenta);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();        }

        protected override string ParticiparEnClase()
        {
            return "Toma clase de" + this.claseQueToma;
        }




    }
}
