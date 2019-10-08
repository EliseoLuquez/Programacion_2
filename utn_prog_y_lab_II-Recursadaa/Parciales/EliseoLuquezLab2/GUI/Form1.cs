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

namespace GUI
{
	public partial class Form1 : Form
	{
		public Maquina m = new Maquina("LAB01PC04");

		public Form1()
		{
			InitializeComponent();
		}


		private void buttonSystemInfo_Click(object sender, EventArgs e)
		{
			richTextBoxsystemInfo.Clear();
			richTextBoxsystemInfo.AppendText(m.SystemInfo);	
		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(m + new PlacaVideo(this.textBoxMarca.Text, this.textBoxModelo.Text, (int)this.numericUpDownMemoria.Value));
			this.textBoxMarca.Text = string.Empty;
			this.textBoxModelo.Text = string.Empty;
			this.numericUpDownMemoria.Value = 0;
		}

		private void buttonSacar_Click(object sender, EventArgs e)
		{
			if(m != null)
			{
				
				MessageBox.Show(m - new PlacaVideo(this.textBoxMarca.Text, this.textBoxModelo.Text, (int)this.numericUpDownMemoria.Value));
			}
		}



	}
}
