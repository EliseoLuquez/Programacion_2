using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
	public class Provincial : Llamada
	{
		protected Franja franjaHoraria;
		private float costoLlamada;

		public float CostoLlamada
		{
			get { return this.CalcularCosto(); }
		}

		public enum Franja
		{
			Franja_1,
			Franja_2,
			Franja_3
		}

		public Provincial(Franja miFranja, Llamada llamada) : base( llamada.Duracion,  llamada.NroDestino, llamada.NroOrigen)
		{
			this.franjaHoraria = miFranja;
		}
		
		public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
		{
			this.franjaHoraria = miFranja;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private float CalcularCosto()
		{
			float costo = 0;
			switch ((int)this.franjaHoraria)
			{
				case (int)Franja.Franja_1:
					costo = 0.99F * this.duracion;
					break;
				case (int)Franja.Franja_2:
					costo = 1.25F * this.duracion;
					break;
				case (int)Franja.Franja_3:
					costo = 0.66F * this.duracion;
					break;
				default:
					break;
			}
			return costo;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string Mostrar()
		{
			StringBuilder sb = new StringBuilder(base.Mostrar());
			sb.Append("\nFranja Horarioa: " + this.franjaHoraria);

			return sb.ToString();
		}

	}
}
