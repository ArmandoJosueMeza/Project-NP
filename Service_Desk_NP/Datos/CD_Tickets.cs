using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Tickets
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar(string tipo_filtro="TODOS", string criterio="")
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_TICKET";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TIPO_FILTRO", tipo_filtro);
            comando.Parameters.AddWithValue("@CRITERIO", criterio);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string no_cliente, string no_serie, string no_tecnico, string fecha, int estado, string problema, string observaciones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_TICKET";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", no_tecnico);
            comando.Parameters.AddWithValue("@FECHA_TICKET", fecha);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@PROBLEMA_REPORTADO", problema);
            comando.Parameters.AddWithValue("@OBSERVACIONES", observaciones);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string no_cliente, string no_serie, string no_tecnico, string fecha, int estado, string problema, string observaciones, string no_ticket)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TICKET";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", no_tecnico);
            comando.Parameters.AddWithValue("@FECHA_TICKET", fecha);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@PROBLEMA_REPORTADO", problema);
            comando.Parameters.AddWithValue("@OBSERVACIONES", observaciones);
            comando.Parameters.AddWithValue("@NO_TICKET", no_ticket);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(string no_ticket)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_TICKET";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TICKET", no_ticket);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
