using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", nombre);
            comando.Parameters.AddWithValue("@APELLIDO_CLIENTE", apellido);
            comando.Parameters.AddWithValue("@EMPRESA", empresa);
            comando.Parameters.AddWithValue("@UBICACION", ubicacion);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.Parameters.AddWithValue("@CORREO", correo);
            comando.ExecuteNonQuery();

        }

    }
}
