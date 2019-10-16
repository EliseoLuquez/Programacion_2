using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get { return this.satelites;}
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre): base(duraOrbita, duraRotacion, nombre)
        {
            this.satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo) : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }


        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            return (planeta.nombre == planeta2.nombre);
        }

        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }


        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite sAux in planeta.satelites)
            {
                if(sAux.Nombre == satelite.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }


        public static bool operator +(Astro astro, Planeta planeta)
        {
            if (astro is Satelite)
            {
                planeta.satelites.Add(astro);
                return true;
            }
            return false;
        }


        public override string Orbitar()
        {
            return string.Format("\nOrbita el planeta {0}", this.nombre);
        }

        public new string Rotacion()
        {
            return string.Format("\nRota el planeta {0}", this.nombre);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Planeta");
            sb.Append(Mostrar());
            //sb.AppendLine("Nombre Planeta: " + this.nombre);
            sb.AppendLine("Tipo: " + this.tipo);
            sb.AppendLine("Cantidad de Satelite: " + this.cantSatelites);
            /*
            foreach (Satelite sAux in satelites)
            {
               sb.AppendLine(sAux.ToString());
            }
            */
            return sb.ToString();
        }
    }
}
