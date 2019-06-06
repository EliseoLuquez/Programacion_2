using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Consola
{
    public abstract  class Universitario : Persona
    {
        private int legajo;


        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendFormat("Legajo {0}", this.legajo);
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        public Universitario()
        {
        }


        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido , dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
            {
                return true;
            }
            return false;
        }


        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            if(obj is Universitario)
            {
                return true;
            }
            return false;
        }



    }
}
