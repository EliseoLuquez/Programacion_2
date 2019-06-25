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
            try
            {
                for(int i = 0; i < datos.Count(); i++)
                {
                    Patente p = datos.Dequeue();
                    sw.WriteLine(p.ToString());
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error al Guardar archivo de texto" + e.Message, e);
            }
            finally
            {
               sw.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            try
            {
                datos = new Queue<Patente>();
                string p = sr.ReadLine();
                while(sr.EndOfStream)
                {
                    datos.Enqueue(new Patente(p, p.Length == 5 ? Patente.Tipo.Vieja :
                    Patente.Tipo.Mercosur));  
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error al Leer archivo de texto" + e.Message, e);
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
