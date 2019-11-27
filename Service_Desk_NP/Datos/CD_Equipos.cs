using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class CD_Equipos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@EQUIPO", equipo);
            comando.Parameters.AddWithValue("@MARCA", marca);
            comando.Parameters.AddWithValue("@MODELO", modelo);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@CLAVE_ACCESO", clave_acceso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@EQUIPO", equipo);
            comando.Parameters.AddWithValue("@MARCA", marca);
            comando.Parameters.AddWithValue("@MODELO", modelo);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@CLAVE_ACCESO", clave_acceso);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(string no_serie)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("NO_SERIE", no_serie);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
