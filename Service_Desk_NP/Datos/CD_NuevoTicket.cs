using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// IMPORTACION DE LA CLASES PARA 
/// LA CONEXION CON LA BASE DE DATOS 
/// EN SQL SERVER 
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    /// <summary>
    /// CLASE TICKETS
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD TICKETS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_NuevoTicket
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DE LOS TICKETS
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarNuevo(string tipo_filtro = "TODOS", string criterio = "")
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

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA INSERTAR TODOS LOS DATOS DE LOS TICKETS
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <param name="problema"></param>
        /// <param name="observaciones"></param>
        public void InsertarNuevo(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_TICKET";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NO_CLIENTE", cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", tecnico);
            comando.Parameters.AddWithValue("@FECHA_TICKET", fecha);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@PROBLEMA_REPORTADO", problema);
            comando.Parameters.AddWithValue("@OBSERVACIONES", observaciones);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA EDITAR TODOS LOS DATOS DE LOS TICKETS
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <param name="problema"></param>
        /// <param name="observaciones"></param>
        /// <param name="no_ticket"></param>
        public void EditarNuevo(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones, string no_ticket)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_TICKET";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@NO_CLIENTE", cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", tecnico);
            comando.Parameters.AddWithValue("@FECHA_TICKET", fecha);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@PROBLEMA_REPORTADO", problema);
            comando.Parameters.AddWithValue("@OBSERVACIONES", observaciones);
            comando.Parameters.AddWithValue("@NO_TICKET", no_ticket);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA ELIMINAR TODOS LOS DATOS DE LOS TICKETS
        /// </summary>
        /// <param name="no_ticket"></param>
        public void EliminarNuevo(string no_ticket)
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
