using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controles;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Xml;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;

        public FrmAerolinea()
        {
            InitializeComponent();

            this.aeropuerto = new Aeropuerto<Vuelo>();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;

            this.Controls.Add(vuelo);
            vuelo.Location = new Point(0, ejeY);
            MetodoExtencion.Metodo();
            vuelo.Despegar();
        }

        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aeropuerto.FinalizarVuelos();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GUARDAR SQL
            MessageBox.Show("No elegi este metodo");/*
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Avion);

            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            try
            {
                comando.CommandText = "INSERT INTO dbo.Bitacora (entrada, alumno) VALUES ('" + DateTime.Now + "', 'Luquez.Eliseo')";
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }*/
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {//ABRIR SQL
            MessageBox.Show("No elegi este metodo");
            /*
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Avion);

            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * From [dbo].Bitacora";
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                
                }
                oDr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            */
            
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {//GUARDAR XML
         // Archivo<Vuelo>.Guardar(aeropuerto); 
           
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {//ABRIR XML
         // Archivo<Vuelo>.Leer();
            Aeropuerto<IAvion> aeropuerto = new Aeropuerto<IAvion>();

            XmlTextReader xmlReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "\\" + "Aeropuerto.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Aeropuerto<IAvion>));
            try
            {
                aeropuerto = (Aeropuerto<IAvion>)xmlSerializer.Deserialize(xmlReader);
                xmlReader.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex);
            }
        }

        private void binarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegi este metodo");
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegi este metodo");
        }
    }
    
}
