using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public class PlacaVideo : Periferico
	{
		private int ramMB;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="marca"></param>
		/// <param name="modelo"></param>
		/// <param name="ramMB"></param>
		public PlacaVideo(string marca, string modelo, int ramMB) : base(marca, modelo, EConector.PCIExpress)
		{
			this.ramMB = ramMB;	
		}

		public override string ExponerDatos()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\nPlaca de Video ");
			sb.Append((string)this);
			sb.Append("\nMemoria " + this.ramMB);
			
			return sb.ToString();
		}

	}
}
