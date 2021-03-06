using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public abstract class Astro
    {
        protected int duraOrbita;
        protected int duracionRotacion;
        protected string nombre;

        [XmlIgnore]
        private Thread hiloOrbita;
        [XmlIgnore]
        private Thread hiloRotacion;

        public event AstroDelegate AstroEvent;

        public int DuraOrbita
        {
            get
            {
                return duraOrbita;
            }
            set
            {
                duraOrbita = value;
            }
        }

        public int DuraRotacion
        {
            get
            {
                return duracionRotacion;
            }
            set
            {
                duracionRotacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        [XmlIgnore]
        public Thread HiloOrbita
        {
            get { return this.hiloOrbita; }
            set { this.hiloOrbita = value; }
        }

        [XmlIgnore]
        public Thread HiloRotacion
        {
            get { return this.hiloRotacion; }
            set { this.hiloRotacion = value; }
        }


        public Astro() { }
        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duraOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Duracion de la orbita: {duraOrbita}");
            retorno.AppendLine($"Duracion de la rotacion: {duracionRotacion}");
            return retorno.ToString();
        }

        public void MiEvento(string mensaje)
        {
            AstroEvent(mensaje);
        }
    }
}
