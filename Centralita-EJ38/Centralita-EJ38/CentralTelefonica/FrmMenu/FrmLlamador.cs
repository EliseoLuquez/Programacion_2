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
	public partial class FrmLlamador : Form
	{
		Centralita centralita;
		public FrmLlamador(Centralita centralita)
		{
			InitializeComponent();
			this.centralita = centralita;
			// Carga 
			cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
			this.txtNroDestino.ReadOnly = true;

		}

		public Centralita Centralita
		{
			get { return this.centralita; }
		}


		private void btnLlamar_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			float randomDuracion = random.Next(1, 50);
			float randomCosto = (float)(random.NextDouble() * (5.6 - 0.5) + 0.5);
			string nroOrigen = this.txtNroOrigen.Text;
			string nroDestino = this.txtNroDestino.Text;

			// Lectura 
			Provincial.Franja franja;
			Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);

			if (nroDestino.StartsWith("#"))
			{
				Provincial llamada = new Provincial(nroOrigen, franja, randomDuracion, nroDestino);
				this.centralita += llamada;
				//llamada.Guardar();
			}
			else
			{
				Local local = new Local(nroOrigen, randomDuracion, nroDestino, randomCosto);
				this.centralita += local;
			}
			this.txtNroDestino.Clear();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.Clear();
			this.txtNroOrigen.Clear();
			this.txtNroDestino.Enabled = true;
		}

		private void btnNum1_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("1");
		}

		private void btnNum2_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("2");
		}

		private void btnNum3_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("3");
		}

		private void btnNum4_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("4");
		}

		private void btnNum5_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("5");
		}

		private void btnNum6_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("6");
		}

		private void btnNum7_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("7");
		}

		private void btnNum8_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("8");
		}

		private void btnNum9_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("9");
		}

		private void btnNumAsterisco_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("*");
		}

		private void btnNum0_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("0");
		}

		private void btnNumNumeral_Click(object sender, EventArgs e)
		{
			this.txtNroDestino.AppendText("#");
		}

		private void txtNroDestino_TextChanged(object sender, EventArgs e)
		{
			if(this.txtNroDestino.Text.StartsWith("#"))
			{
				this.cmbFranja.Enabled = false;
			}
		}
	}
}
