using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set { directorTecnico = value.ValidarAptitud() == true ? value : null; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /*El operador explícito retornará los datos del equipo, su director técnico (en caso de no tener uno
        asignado aún, mostrar en su lugar el string "Sin DT asignado") y todos sus jugadores, utilizando
        StringBuilder para compilar dicha información.*/
       public static explicit operator string(Equipo e)
       {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nNombre Equipo: " + e.Nombre);
			if(e.jugadores != null)
			{
				foreach(Jugador j in e.jugadores)
				{
					sb.Append(j.Mostrar());
				}
			}
            
            sb.Append( e.directorTecnico != null ? "\nDirector Tecnico: " + e.directorTecnico.Mostrar() : 
                "\nSin DT Asginado");
            return sb.ToString();

       }

       public static bool operator ==(Equipo e, Jugador j)
       {
			return e.jugadores.Contains(j);
		}

	   public static bool operator !=(Equipo e, Jugador j)
	   {
			return !(e == j);
	   }


	   public static Equipo operator +(Equipo e, Jugador j)
	   {
			if(e != j && e.jugadores.Count() < cantidadMaximaJugadores && j.ValidarAptitud())
			{
				e.jugadores.Add(j);
			}
			return e;
	   }

	   public static bool ValidarEquipo(Equipo e)
	   {
			bool validar = false;
			int contArq = 0;
			int contDef = 0;
			int contMed = 0;
			int contDel = 0;
			int todos = 0;
			if(e.directorTecnico != null && e.jugadores.Count() >= cantidadMaximaJugadores )
			{
				foreach(Jugador j in e.jugadores)
				{
					switch(j.Posicion)
					{
						case Posicion.Arquero:
							contArq++;
							break;
						case Posicion.Defensor:
							contDef++;
							todos++;
							break;
						case Posicion.Central:
							contMed++;
							todos++;
							break;
						case Posicion.Delantero:
							contDel++;
							todos++;
							break;
					}
				}
				if(contArq == 1 && todos >= 5)
				{
					validar = true;
				}
			}
			return validar;
	   }


	}
}
