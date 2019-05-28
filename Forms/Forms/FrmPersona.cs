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
    public partial class FrmPersona : Form
    {
        public Persona persona;
        public FrmPersona()
        {
            InitializeComponent();
            persona = new Persona();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            persona.nombre = txtNombre.Text;
            persona.apellido = txtApellido.Text;
            persona.dni = txtDNI.Text;
            persona.numTarjeta = txtNTarjeta.Text;
            this.DialogResult = DialogResult.OK;

 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
