using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormParcial
{
    public partial class FormSistemaSolar : Form
    {
        public static List<Astro> planetas;

        public FormSistemaSolar()
        {
            InitializeComponent();
            planetas = new List<Astro>();
            this.cmbTipo.DataSource = Enum.GetNames(typeof(Tipo));
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Int32.TryParse(txtOrbitaPlaneta.Text, out int orbitaP);

            if ((txtNombrePlaneta.Text != string.Empty) || (txtOrbitaPlaneta.Text != string.Empty) || (numRotacion.Value >= 0)
                || (numSatelite.Value >= 0) || (cmbTipo.Text != string.Empty))
            {
                Planeta planeta = new Planeta(orbitaP, (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numSatelite.Value, (Tipo)cmbTipo.SelectedIndex);

                if (planetas.Count == 0)
                {
                    planetas.Add(planeta);
                    cmbPlanetas.Items.Add((string)planeta);
                }
                else
                {
                    foreach (Planeta pAux in planetas)
                    {
                        if (pAux == planeta)
                        {
                            flag = true;
                            break;
                        }


                    }
                    if (!flag)
                    {
                        planetas.Add(planeta);
                        cmbPlanetas.Items.Add((string)planeta);
                    }
                }

            }
            else
            {
                MessageBox.Show("Faltan completar campos");
            }
        }

        private void btnAgergarSatelite_Click(object sender, EventArgs e)
        {
            //bool flag = false;
            if (!(planetas is null) && cmbPlanetas.Text != string.Empty && txtNombreSatelite.Text != string.Empty)
            {
                bool booleano = false;
                if ((cmbPlanetas.SelectedItem.ToString() != string.Empty) || (txtNombreSatelite.Text != string.Empty) ||
                    (numOrbitaSatelite.Value >= 0) || (numRotacionSatelite.Value >= 0))
                {
                    Satelite s = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value,
                        txtNombreSatelite.Text);

                    foreach (Planeta planeta in planetas)
                    {
                        if ((string)planeta == (string)cmbPlanetas.SelectedItem)
                        {
                            booleano = s + planeta;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan completar campos");
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SistemaSolar sistemaSolar = new SistemaSolar();
            richTextBox1.Clear();

            foreach (Planeta planeta in planetas)
            {
                sistemaSolar.Planetas.Add(planeta);
            }
            richTextBox1.AppendText(sistemaSolar.MostrarInformacionAstros());

        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta planeta in planetas)
            {
                richTextBox1.AppendText(planeta.Orbitar());
                richTextBox1.AppendText(planeta.Rotacion());
                foreach (Satelite satelite in planeta.Satelites)
                {
                    richTextBox1.AppendText(satelite.Orbitar());
                    richTextBox1.AppendText(satelite.Rotacion());
                }
            }

        }

        private void FormParcial_Load(object sender, EventArgs e)
        {
            numRotacion.Value = 0;

        }
    }
}
