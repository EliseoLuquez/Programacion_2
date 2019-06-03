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

		public override float CostoLlamada
		{
			get { return this.CalcularCosto(); }
		}

		/// <summary>
		/// 
		/// </summary>
		public enum Franja
		{
			Franja_1,
			Franja_2,
			Franja_3
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="miFranja"></param>
		/// <param name="llamada"></param>
		public Provincial(Franja miFranja, Llamada llamada) : base( llamada.Duracion,  llamada.NroDestino, llamada.NroOrigen)
		{
			this.franjaHoraria = miFranja;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="origen"></param>
		/// <param name="miFranja"></param>
		/// <param name="duracion"></param>
		/// <param name="destino"></param>
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
		protected override string Mostrar()
		{
			StringBuilder sb = new StringBuilder(base.Mostrar());
			sb.Append("\nFranja Horaria: " + this.franjaHoraria);
			sb.Append("\nCosto de Llamada: " + this.CostoLlamada);

			return sb.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			if(obj is Provincial)
			{
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return Mostrar();
		}

	}
}
