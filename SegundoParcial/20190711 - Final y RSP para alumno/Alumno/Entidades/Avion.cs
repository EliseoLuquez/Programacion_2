using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate int ReporteDeEstado(int horasTotales, int horasRestantes);

    public enum EstadoVuelo
    {
        Programado,
        Volando,
        Aterrizado
    }
    [Serializable]
    public class Avion : IAvion
    {
        public event ReporteDeEstado ReportarEstado;
        private int horasVuelo;
        private Thread vuelo;

        public EstadoVuelo Estado
        {
            get
            {
                if (this.vuelo is null)
                {
                    return EstadoVuelo.Programado;
                }
                else if(vuelo.IsAlive)
                {
                    return EstadoVuelo.Volando;
                }
                else
                {
                    return EstadoVuelo.Aterrizado;
                }
            }
        }

        public int HorasDeVuelo
        {
            get { return this.horasVuelo; }
        }

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
                Thread.Sleep(1000);
                horasRestantes--;
                porcentajeCompletado = this.ReportarEstado(this.horasVuelo, horasRestantes);
            }
        }

        public void Despegar()
        {
            this.vuelo = new Thread(this.Volar);
            this.vuelo.Start();
        }

        public void Estrellar()
        {
            if (this.vuelo.IsAlive)
            {
                this.vuelo.Abort();
            }
        }







    }
}
