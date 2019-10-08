using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Entidades
{
	public class Maquina
	{
		private int cantidadMaxPerifericos;
		private string nombre;
		private List<Periferico> perifericos;

		/// <summary>
		/// 
		/// </summary>
		public int CantidadMaximaPerifericos
		{
			get
			{
				if(cantidadMaxPerifericos < 1 || cantidadMaxPerifericos > 4)
				{
					if(cantidadMaxPerifericos < 1)
					{
						return cantidadMaxPerifericos = 1;
					}
					else
					{
						return cantidadMaxPerifericos = 4;
					}
				}
				else
				{
                    return cantidadMaxPerifericos;

                }
			}
            set { this.cantidadMaxPerifericos = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string  SystemInfo
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("\n" + this.nombre + ":");
				foreach(Periferico p in perifericos)
				{
					if(p is Teclado)
					{
						sb.Append("\n" + p.ExponerDatos());
					}
					else if(p is PlacaVideo)
					{
						sb.Append("\n"+ p.ExponerDatos());
					}
				}
				
				return sb.ToString();
			}

		}

		/// <summary>
		/// 
		/// </summary>
		private Maquina()
		{
			this.perifericos = new List<Periferico>();
			this.CantidadMaximaPerifericos = 3;
		}

		public Maquina(string nombre) : this()
		{
			this.nombre = nombre;
		}

		public static bool operator ==(Maquina m, Periferico p)
		{
			bool validar = false;
			foreach(Periferico pAux in m.perifericos)
			{
				if(pAux == p)
				{
					validar = true;
					break;
				}
			}
		    return validar;
		}

		public static bool operator !=(Maquina m, Periferico p)
		{
			return !(m == p);
		}

		public static string operator +(Maquina m, Periferico p)
		{
			int cantidad;
			cantidad = m.perifericos.Count();
			if(m == p || cantidad >= m.CantidadMaximaPerifericos)
			{

				return String.Format("No se puede Conectar el dispositivo!");
			}
			else
			{
				m.perifericos.Add(p);
				return String.Format("Periferico Conectado!");
			}
		}

		public static string operator -(Maquina m, Periferico p)
		{
			foreach(Periferico pAux in m.perifericos)
			{
				if(p == pAux)
				{
					m.perifericos.Remove(pAux);
					return String.Format("Periferico Desconectado!");
				}
			}
			return String.Format("No se puede desconectar el dispositivo!");
		}

	}
}
