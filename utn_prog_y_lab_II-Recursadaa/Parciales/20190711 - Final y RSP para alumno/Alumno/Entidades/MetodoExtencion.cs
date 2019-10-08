using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public static class MetodoExtencion 
    {
        public static void Metodo()
        {
            //GUARDAR SQL
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Avion);
            
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            try
            {
                comando.CommandText = "INSERT INTO dbo.Bitacora (entrada, alumno) VALUES ('" + DateTime.Now + "', 'Luquez.Eliseo')";
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                 throw new ErrorArchivoException(e);
            }
             
        }
    }
}
