using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FrmMenu
{
	public partial class FrmMenu : Form
	{
		Centralita centralita;
		public FrmMenu()
		{
			InitializeComponent();
			centralita = new Centralita("Cheo Center");
		}


		


		private void btnGenerarLlamada_Click(object sender, EventArgs e)
		{
			FrmLlamador frmLlamador = new FrmLlamador(centralita);
			frmLlamador.ShowDialog();
			this.centralita = frmLlamador.Centralita;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
