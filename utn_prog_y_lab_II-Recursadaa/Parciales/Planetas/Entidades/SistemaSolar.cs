using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;


        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }


        public List<Astro> Planetas
        {
            get { return this.planetas; }
        }


        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta planeta in this.planetas)
            {
                sb.AppendLine(planeta.ToString());
                
                foreach (Satelite satelite in planeta.Satelites)
                {
                    sb.AppendLine(satelite.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
