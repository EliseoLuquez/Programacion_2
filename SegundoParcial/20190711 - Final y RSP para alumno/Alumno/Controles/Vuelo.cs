﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace Controles
{
    [Serializable]
    public partial class Vuelo : UserControl, IAvion
    {
        private Avion avion;

        public EstadoVuelo Estado{ get { return avion.Estado; } }

        public void Despegar()
        {
            picAvion.Visible = true;
            avion.Despegar();
        }

        public void Estrellar()
        {
            avion.Estrellar();
        }

        public Vuelo(int horasVuelo)
        {
            InitializeComponent();
            this.avion = new Avion(horasVuelo);
            this.avion.ReportarEstado += MoverAvion;//Asi se asocia el evento
        }

        public int MoverAvion(int horasTotales, int horasRestantes)
        {
            if (this.picAvion.InvokeRequired)
            {
                ReporteDeEstado reporte = new ReporteDeEstado(MoverAvion);
                this.Invoke(reporte, new object[] { horasTotales, horasRestantes });
                return 0;
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);

                return porcentajeCompletado;
            }
        }
    }
}
