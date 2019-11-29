using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + "\\Guardarplantxt.txt", true))
            {
                try
                {
                    sw.WriteLine(plan.ToString(), true);
                    return true;
                }

                catch (Exception e)
                {
                    throw e;                  
                }
            }
        }

        public static bool GuardarXml(this Satelite sat)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Satelite));
                TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    + "\\GuardarXml.xml");

                serializer.Serialize(writer, sat);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }       
        }
    }
}
