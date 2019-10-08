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
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{

    public partial class FrmPpal : Form
    {
        List<Thread> hilos;
        Queue<Patente> cola;
       // public event MostrarPatente VistaPatente;

        public FrmPpal()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion +=  this.ProximaPatente;
            this.vistaPatente2.finExposicion +=  this.ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Patente p;
            Xml<Patente> xml = new Xml<Patente>();
            xml.Leer("patentes.xml", out p);
            this.InicializarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            //En cada botón leer del origen que corresponda (SQL, XML, TXT) agregar los datos a la
            //cola de Patentes. También capturar las excepciones y llamar al método IniciarSimulacion.
            Texto texto = new Texto();
            texto.Leer("patentes.txt", out cola);

            this.InicializarSimulacion();            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {

            Sql sql = new Sql();
            sql.Leer("patentes-sp-2018", out cola);     

            this.InicializarSimulacion();
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread thread in hilos)
            {
                if (thread.IsAlive && thread != null)
                {
                    thread.Abort();
                }
            }
        }


        private void InicializarSimulacion()
        {
            this.FinalizarSimulacion();
            //Llamará al método ProximaPatente para cada uno de los objetos del tipo VistaPatente del
            //formulario.
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }

        private void ProximaPatente(VistaPatente vp)
        {
            if(this.hilos.Count > 0)
            {
                Thread hilo = new Thread(vp.MostrarPatente);
                //Inicializará el hilo recién creado con el próximo elemento de la cola.             
                hilo.Start(cola.Dequeue());
                //Agregará el hilo a la lista.
                this.hilos.Add(hilo);

            }
        }

    }
}
