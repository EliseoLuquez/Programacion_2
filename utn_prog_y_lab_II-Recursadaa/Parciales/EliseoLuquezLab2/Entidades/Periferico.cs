using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public abstract class Periferico
	{
		private EConector conector;
		private string marca;
		private string modelo;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="modelo"></param>
		/// <param name="conector"></param>
		public Periferico(string marca, string modelo, EConector conector)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.conector = conector;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="p"></param>
		public static explicit operator string(Periferico p)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0} {1} {2}", p.marca, p.modelo, p.conector);
			return sb.ToString();
		}  

		/// <summary>
		/// 
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static bool operator ==(Periferico p1, Periferico p2)
		{
			return (p1.marca == p2.marca && p1.modelo == p2.modelo ? true : false);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		public static bool operator !=(Periferico p1, Periferico p2)
		{
			return !(p1 == p2);
		}

		public abstract string ExponerDatos();







	}
}
