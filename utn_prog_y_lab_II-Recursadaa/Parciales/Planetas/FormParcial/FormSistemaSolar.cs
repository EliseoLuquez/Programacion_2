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
        public SistemaSolar ss;
        public Planeta p;
        public FormSistemaSolar()
        {
            InitializeComponent();
            planetas = new List<Astro>();
            this.cmbTipo.DataSource = Enum.GetNames(typeof(Tipo));
            ss = new SistemaSolar();
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Int32.TryParse(txtOrbitaPlaneta.Text, out int orbitaP);

            if ((txtNombrePlaneta.Text != string.Empty) || (txtOrbitaPlaneta.Text != string.Empty) || (numRotacion.Value >= 0)
                || (numSatelite.Value >= 0) || (cmbTipo.Text != string.Empty))
            {
                p = new Planeta(orbitaP, Convert.ToInt32(numRotacion.Value), txtNombrePlaneta.Text, Convert.ToInt32(numSatelite.Value), (Tipo)cmbTipo.SelectedIndex);

                if (planetas.Count == 0)
                {
                    planetas.Add(p);
                    cmbPlanetas.Items.Add((string)p);
                    ss.Planetas.Add(p);
                }
                else
                {
                    foreach (Planeta pAux in planetas)
                    {
                        if (pAux == p)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        planetas.Add(p);
                        cmbPlanetas.Items.Add((string)p);
                        ss.Planetas.Add(p);
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
            bool flag = false;
            if (!(planetas is null) && cmbPlanetas.Text != string.Empty && txtNombreSatelite.Text != string.Empty)
            {
                bool booleano = false;
                if ((cmbPlanetas.SelectedItem.ToString() != string.Empty) || (txtNombreSatelite.Text != string.Empty) ||
                    (numOrbitaSatelite.Value >= 0) || (numRotacionSatelite.Value >= 0))
                {
                    Satelite s = new Satelite(Convert.ToInt32(numOrbitaSatelite.Value), Convert.ToInt32(numRotacionSatelite.Value),
                        txtNombreSatelite.Text);

                    if (p.Satelites.Count == 0)
                    {
                        booleano = p + s;
                    }
                    else
                    {
                        foreach (Planeta pAux in planetas)
                        {
                            foreach (Satelite sAux in p.Satelites)
                            {
                                if (pAux == s)
                                {
                                    flag = true;
                                    
                                }
                            }
                        }
                        if (!flag)
                        {
                            booleano = p + s;
                            //p.Satelites.Add(s);
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
            //SistemaSolar ss = new SistemaSolar();
            richTextBox1.Clear();
            richTextBox1.AppendText(ss.MostrarInformacionAstros());

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
