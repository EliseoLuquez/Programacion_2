using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace Sender
{
    public partial class FrmSender : Form
    {
		private ManejadorDeEmisores manejador;
		private List<Emisor.EProducto> productos;
		private EmisorDeWhatsapp whatsapp;

		public FrmSender()
        {
            InitializeComponent();
            manejador = new ManejadorDeEmisores("West Europe");
			productos = new List<Emisor.EProducto>();
		    this.cmbProducto.DataSource = Enum.GetNames(typeof(Emisor.EProducto));
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
			richConsola.Clear();
			richMensaje.Clear();
			cmbProducto.SelectedItem = string.Empty;
			txtTelefono.Text = string.Empty;
			richConsola.AppendText(manejador.EnviarMensajes());
		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {                                                                                                                                                                                                                                                      
			Emisor.EProducto producto;
			Enum.TryParse(this.cmbProducto.SelectedItem.ToString(), out producto);
			whatsapp = new EmisorDeWhatsapp(richMensaje.Text, producto);
			if (manejador + whatsapp)
			{
				whatsapp.NumeroTelefono = Convert.ToInt32(txtTelefono.Text);
				MessageBox.Show("Mensaje Agregado!");
			}
			else
			{
				MessageBox.Show("No se pudo Agregar Mensaje!");
			}

        }

       
    }
}
