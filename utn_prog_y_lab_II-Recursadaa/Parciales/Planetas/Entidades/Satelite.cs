using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get { return this.nombre; }
        }

        public Satelite(int duraOrbita, int duraRotacion, string nombre): base(duraOrbita, duraRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            return string.Format("\nOrbitar el satelite: {0}", this.Nombre);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Satelite");
            sb.AppendLine(Mostrar());
            
            return sb.ToString();
        }
        
    }
}
