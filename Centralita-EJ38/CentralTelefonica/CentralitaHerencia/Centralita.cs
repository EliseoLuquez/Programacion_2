using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincia
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

		public Centralita()
		{
			this.listaDeLlamadas = new List<Llamada>();
		}

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }


		public Centralita(string nombreEmpresa) : this()
		{
			this.razonSocial = nombreEmpresa;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tipo"></param>
		/// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
			float total = 0;

			foreach (Llamada ll in this.Llamadas)
			{
				if (tipo == Llamada.TipoLlamada.Local)
				{
					if (ll is Local)
						total += ((Local)ll).CostoLlamada;
				}
				else if (tipo == Llamada.TipoLlamada.Provincial)
				{
					if (ll is Provincial)
						total += ((Provincial)ll).CostoLlamada;
				}
				else
				{
					//(tipo == Llamada.TipoLlamada.Todas)
					if (ll is Local)
						total += ((Local)ll).CostoLlamada;
					else
						total += ((Provincial)ll).CostoLlamada;
				}
			}
			return total;
        }


		public string Mostrar()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("\nRazon Social: " + this.razonSocial);
			sb.Append("\nGanancia Local:: " + this.GananciasPorLocal);
			sb.Append("\nGanancia Provincia: " + this.GananciasPorProvincia);
			sb.Append("\nGanancia Total: " + this.GananciasPorTotal);
			foreach (Llamada llamada in this.Llamadas)
			{
				sb.Append(llamada is Local ? ((Local)llamada).Mostrar() : ((Provincial)llamada).Mostrar());
			}
			return sb.ToString();

		}


		public void OrdenarLlamadas()
		{
			this.Llamadas.Sort(Llamada.OrdenarPorDuracion);	
		}
    }
}
