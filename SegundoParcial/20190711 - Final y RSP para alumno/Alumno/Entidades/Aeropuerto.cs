using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public Aeropuerto()
        {
           this.vuelos = new List<T>();
        }

        public static explicit operator String(Aeropuerto<T> a)
        {
            int contador = 0;
            
            foreach(T vuelo in a.vuelos)
            {
                if(vuelo.Estado == EstadoVuelo.Volando)
                {
                    contador++;
                }
            }
            return String.Format("El aeropuerto cuenta con {0} vuelos en estado Volando", contador);
        }

        public void FinalizarVuelos()
        {
            foreach (IAvion avion in this.vuelos)
            {
                avion.Estrellar();
            }
        }

        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            if(!(a.vuelos is null))
            {
                a.vuelos.Add(vuelo);
            }
            return a.vuelos.Count * 50;
        }
    }
}
