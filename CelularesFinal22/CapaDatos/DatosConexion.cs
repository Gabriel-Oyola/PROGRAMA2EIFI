using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosConexion
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = @"Data Source=DESKTOP-NUSLQEB\SQLEXPRESS;Initial Catalog=CelularesFinal;Integrated Security=True";
        //
        // @"Data Source = DESKTOP-98UKOSL\SQLEXPRESS;Initial Catalog = CelularesFinal; Integrated Security = True";

        public DatosConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }

}

