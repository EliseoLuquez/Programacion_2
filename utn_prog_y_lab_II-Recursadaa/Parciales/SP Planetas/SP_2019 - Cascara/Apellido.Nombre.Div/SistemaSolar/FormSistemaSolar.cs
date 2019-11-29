using System;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SistemaSolar
{

    public partial class FormSistemaSolar : Form
    {
        private Planeta<Satelite> planeta;
        public FormSistemaSolar()
        {
            InitializeComponent();
            


        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if (planeta.HiloRotacion is null)
            {
                planeta.AstroEvent += this.MostrarMensajeRotar;
                //Creo Manejador de eventos MostrarMensajeRotar

                Thread hilo = new Thread(planeta.RunEvntRotar);
                planeta.HiloRotacion = hilo;
                hilo.Start();

            }
        }

        private void MostrarMensajeRotar(string mensaje)
        {
            this.MostrarMensaje(mensaje);
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            foreach (Satelite satelite in planeta.Satelites)
            {
                if (planeta.HiloOrbita is null)
                {
                   // satelite.AstroEvent += MostrarMensajeRotar;
                    //Creo Manejador de eventos MostrarMensajeRotar
                    Thread hilo = new Thread(satelite.RunEvntOrb);
                    satelite.HiloOrbita = hilo;
                    hilo.Start();
                }

            }
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            int.TryParse(this.txOrbita.Text, out int orbita);
            int.TryParse(this.txRota.Text, out int rota);
            SateliteDB sdb = new SateliteDB();
            try
            {
                Satelite satelite = new Satelite(rota, orbita, this.txNombre.Text);
                if (sdb.Guardar(satelite))
                {
                    planeta.Satelites.Add(satelite);
                    satelite.AstroEvent += MostrarMensajeRotar;
                    MessageBox.Show("Satelite Guardado correctamente");
                    txNombre.Text = string.Empty;
                    txOrbita.Text = string.Empty;
                    txRota.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Satelite No Guardado correctamente");
                }
            }
            catch (SateliteException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            this.planeta = new Planeta<Satelite>(20, 20, "Jupiter");
            SateliteDB sb = new SateliteDB();
            planeta.Satelites = sb.Leer();

        }
    }
}
