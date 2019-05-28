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
		Maquina m = new Maquina("LAB01PC03");

		public Form1()
		{
			InitializeComponent();
		}


		private void buttonSystemInfo_Click(object sender, EventArgs e)
		{
			richTextBoxsystemInfo.AppendText(m.SystemInfo);	
		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(m + new PlacaVideo(textBoxMarca.Text, textBoxModelo.Text, (int)numericUpDownMemoria.Value));
		}

		private void buttonSacar_Click(object sender, EventArgs e)
		{
			if(m != null)
			{
				
			}
		}

		private void listBoxMemoria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}



	}
}
