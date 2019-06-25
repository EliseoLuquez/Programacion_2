using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextWriter xmlWriter = new XmlTextWriter(archivo, Encoding.ASCII);
            try
            {    
                serializer.Serialize(xmlWriter, datos);
            }
            catch (Exception e)
            {
                throw new Exception("Error al serializar\n" + e.Message, e);
            }
            finally
            {
                xmlWriter.Close();
            }

        }


        public void Leer(string archivo, out T datos)
        {
            XmlTextReader xmlReader = new XmlTextReader(archivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            try
            {
                datos = (T)xmlSerializer.Deserialize(xmlReader);
            }
            catch (Exception e)
            {
                throw new Exception("Error al deserializar\n" + e.Message, e);
            }
            finally
            {
                xmlReader.Close();
            }

        }
    }
}
