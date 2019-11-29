using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class SateliteDB
    {

        private SqlCommand comando;
        private SqlConnection conexion;

        public SateliteDB()
        {

            conexion = new SqlConnection("Data Source = ROMY; Initial Catalog = planetario;" +
                " Integrated Security = True");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public bool Guardar(Satelite satelite)
        {
            try
            {
                comando.Connection.Open();
                comando.CommandText = "INSERT INTO dbo.Satelites (duracion_orbita, duracion_rotacion, nombre)" +
                  " VALUES('" + satelite.DuraOrbita + "','" + satelite.DuraRotacion + "','" + satelite.Nombre +"')" ;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Satelite> Leer()
        {
            try
            {
                comando.Connection.Open();
                List<Satelite> satList = new List<Satelite>();
                comando.CommandText = "SELECT * From [dbo].Satelites";
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    int.TryParse(dr["duracion_orbita"].ToString(), out int orbita);
                    int.TryParse(dr["duracion_rotacion"].ToString(), out int rota);
                    Satelite satelite = new Satelite(orbita, rota, dr["nombre"].ToString());
                    satList.Add(satelite);
                }
                dr.Close();
                return satList;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
