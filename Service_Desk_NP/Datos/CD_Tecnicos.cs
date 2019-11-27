using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class CD_Tecnicos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_TECNICO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string apellido, string telefono, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_TECNICO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_TECNICO", nombre);
            comando.Parameters.AddWithValue("@APELLIDO_TECNICO", apellido);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.Parameters.AddWithValue("@CORREO", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string apellido, string telefono, string correo, string no_tecnico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TECNICO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_TECNICO", nombre);
            comando.Parameters.AddWithValue("@APELLIDO_TECNICO", apellido);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.Parameters.AddWithValue("@CORREO", correo);
            comando.Parameters.AddWithValue("@NO_TECNICO", no_tecnico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(string no_tecnico)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_TECNICO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TECNICO", no_tecnico);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }





    }
}
