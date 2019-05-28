using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class Teclado : Periferico
	{
		EDistribucion distribucion;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="modelo"></param>
		/// <param name="conector"></param>
		public Teclado(string marca, string modelo, EConector conector) : base(marca, modelo, conector)
		{
			this.distribucion = EDistribucion.DVorak;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="modelo"></param>
		/// <param name="conector"></param>
		/// <param name="distribucion"></param>
		public Teclado(string marca, string modelo, EConector conector, EDistribucion distribucion) : base(marca, modelo, conector)
		{
			this.distribucion = distribucion;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ExponerDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\nTeclado ");
			sb.Append((string)this);
			sb.Append("\nDistribucion " + this.distribucion);
			return sb.ToString();
		}


		public enum EDistribucion
		{
			DVorak,
			QWERTY,
			QWERTZ,
			AZERTY
		}
	}
}
