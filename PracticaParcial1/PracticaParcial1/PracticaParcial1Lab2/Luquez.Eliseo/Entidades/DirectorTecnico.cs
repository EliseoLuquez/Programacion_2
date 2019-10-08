using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get { return añosExperiencia; }
            set { añosExperiencia = value; }
        }


        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base (nombre, apellido, dni, edad)
        {
            this.añosExperiencia = añosExperiencia;
        }
        
        public override string  Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.Append("\nAños de Experiencia: " + this.AñosExperiencia);

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            //ValidarAptitud validará que el Director Técnico sea menor a 65 años y tenga al menos 2 años de
            //experiencia.
            bool validar = false;
            validar = (this.Edad <= 65 && this.añosExperiencia >= 2) ? true : false;
            return validar;
        }


    }
}
