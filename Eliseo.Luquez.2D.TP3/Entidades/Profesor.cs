using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Consola
{
    sealed class Profesor : Universitario
    {
        /* Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
         Sobrescribir el método MostrarDatos con todos los datos del profesor.
          ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
         ToString hará públicos los datos del Profesor.
         Se inicializará a Random sólo en un constructor.
         En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
        mediante el método randomClases. Las dos clases pueden o no ser la misma.
       
         */
        private Queue<Entidades.Universidad.EClases> claseDelDia;
        private static Random random;


        static Profesor()
        {

        }

        private  Profesor() 
        {
            this.claseDelDia = new Queue<Entidades.Universidad.EClases>();
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad): base(id, nombre,
            apellido, dni, nacionalidad)
        {

        }

        //  Un Profesor será igual a un EClase si da esa clase.
        public static bool operator ==(Profesor i, Entidades.Universidad.EClases clase)
        {
            foreach(Entidades.Universidad.EClases claseAux in i.claseDelDia)
            {
                if (claseAux == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor i, Entidades.Universidad.EClases clase)
        {
            return !(i == clase);
        }


        protected  override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clases del dia: ");
            foreach (Entidades.Universidad.EClases clases in this.claseDelDia)
            {
                sb.Append(this.claseDelDia);
            }
            return sb.ToString() ;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }

        private void _randomClases()
        {
            random.
        }



    }
}
