using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {

        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter(archivo);
            for(int i = 0; i < datos.Count(); i++)
            {
                Patente p = datos.Dequeue();
                sw.WriteLine(p.ToString());
            }
            sw.Close();
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = new Queue<Patente>();
            string p = sr.ReadLine();
            while(p.Length > 0)
            {
                datos.Enqueue(new Patente(p, p.Length == 5 ? Patente.Tipo.Vieja : Patente.Tipo.Mercosur));
            }

            sr.Close();
      

        }
    }
}
