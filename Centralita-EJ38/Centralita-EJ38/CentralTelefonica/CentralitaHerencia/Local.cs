using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentralitaHerencia
{
    public class Local : Llamada , IGuardar<Local>
    {
        protected  float costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

		public string RutaDeArchivo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        private float CalcularCosto()
        {
           return this.duracion * this.costo;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="llamada"></param>
		/// <param name="costo"></param>
        public  Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="origen"></param>
		/// <param name="duracion"></param>
		/// <param name="destino"></param>
		/// <param name="costo"></param>
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string Mostrar()
		{
			StringBuilder sb = new StringBuilder(base.Mostrar());
			sb.Append("\nCosto LLamada: " + this.CostoLlamada);

			return sb.ToString();
		}

		public override bool Equals(object obj)
		{
			if(obj is Local)
			{
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return Mostrar();
		}

		public bool Guardar()
		{
			StreamWriter sw = new StreamWriter(RutaDeArchivo);
			try
			{
				sw.WriteLine(ToString());
				return true;
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				sw.Close();
			}
		}


		public Local Leer()
		{
			StreamReader sr = new StreamReader(RutaDeArchivo);
			try
			{
				sr.ReadToEnd();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				sr.Close();
			}
			throw new NotImplementedException();
		}

	}
}
