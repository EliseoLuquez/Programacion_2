using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmPpal : Form
    {
        public  List<Persona> personas;
        public FrmPersona formPersona = new FrmPersona();

        public FrmPpal()
        {
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            if(formPersona.ShowDialog() == DialogResult.OK)
            {
                personas.Add(formPersona.persona);
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            foreach(Persona p in personas)
            {
                listPersonas.Items.Add(p);
            }
            
        }
    }
}
