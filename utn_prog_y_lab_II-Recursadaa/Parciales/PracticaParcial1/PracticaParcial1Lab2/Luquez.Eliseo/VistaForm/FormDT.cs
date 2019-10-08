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

namespace VistaForm
{
    public partial class FormDT : Form
	{
		DirectorTecnico dt;

		public FormDT()
		{
			InitializeComponent();
		}

		private void btnValidar_Click(object sender, EventArgs e)
		{
			if(this.dt != null)
			{
				MessageBox.Show(dt.ValidarAptitud() ? "El DT Es apto" : "El DT No es apto");
			}
			else
			{
				MessageBox.Show("Aun no se ha creado el DT del formulario");
			}
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			this.dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)numUpDownEdad.Value, 
				(int)numUpDownDni.Value, (int)numUpDownExp.Value);
			MessageBox.Show(dt != null ? "Se ha creado el DT" : "Error al crear DT");
		}

		
	}
}
