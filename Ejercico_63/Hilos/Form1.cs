using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace Hilos
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        delegate void Callback(); 
        private void AsignarHora()
        {
            int num = 0;
            while (num < 1000)
            {

                if (this.lblHora.InvokeRequired)
                {
                    Callback d = new Callback(this.AsignarHora);
                    this.lblHora.Invoke(d);
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString(); 
                }

                num++;
            }
            


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(AsignarHora);
            t.Start();   
        }
    }
}
