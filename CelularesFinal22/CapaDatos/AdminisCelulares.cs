using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;



namespace CapaDatos
{
    public class AdminisCelulares : DatosConexion
    {
        public int abmCelulares(string accion, Celulares objCelulares)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Celulares values ({objCelulares.p_id},'{objCelulares.P_Marca}','{objCelulares.p_Modelo}','{objCelulares.P_Repacion}','{objCelulares.P_Estado}',{objCelulares.P_DniT},{objCelulares.P_Costo_total},'{objCelulares.P_FechaIngreso}','{objCelulares.P_FechaEgreso}' );";
            if (accion == "Modificar")
                orden = orden = $"update Celulares set Marca = '{objCelulares.P_Marca}', Modelo = '{objCelulares.p_Modelo}', Reparacion = '{objCelulares.P_Repacion}', Estado = '{objCelulares.P_Estado}', Dni_Tecnico = '{objCelulares.P_DniT}', Costo_total = '{objCelulares.P_Costo_total}', FechaIngreso = '{objCelulares.P_FechaIngreso}', FechaEgreso = '{objCelulares.P_FechaEgreso}' where CodCelular = {objCelulares.p_id} ; ";
            if (accion == "Borrar")
                orden = $"delete from Celulares where CodCelular = {objCelulares.p_id}; ";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                 throw new Exception($"Errror al tratar de guardar,borrar o modificar ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoCelulares(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Celulares where CodCelular = " + int.Parse(cual) + ";";
            else
                orden = "select * from Celulares;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Celulares", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }


    }
}
