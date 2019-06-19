using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            
        }


        public void Guardar(string tabla, Queue<Patente> datos)
        {
            conexion.Open();
            while (datos.Count > 0)
            {
                Patente p = datos.Dequeue();
                comando.CommandText = "INSERT into [dbo].Patentes Values ('" + p.CodigoPatente + "' , '" +
                    p.TipoCodigo.ToString() + "');";
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }
        public void Leer(string tabla, out Queue<Patente> datos)
        {
            conexion.Open();
            datos = new Queue<Patente>();
            comando.CommandText = "SELECT * From [dbo].Patentes";
            SqlDataReader oDr = comando.ExecuteReader();
            while (oDr.Read())
            {
                Patente p = new Patente(oDr["Patente"].ToString(), oDr["Tipo"].ToString() == Patente.Tipo.Mercosur.ToString()
                    ? Patente.Tipo.Mercosur : Patente.Tipo.Vieja);
                datos.Enqueue(p);    
            }

            conexion.Close();


        }




    }
}
