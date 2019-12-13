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
    /// CLASE ENTREGAS
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD ENTREGAS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_NuevoEntrega
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DE LAS ENTREGAS
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarNuevo(string tipo_filtro = "TODOS", string criterio = "")
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TIPO_FILTRO", tipo_filtro);
            comando.Parameters.AddWithValue("@CRITERIO", criterio);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA INSERTAR TODOS LOS DATOS DE LAS ENTREGAS
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        public void InsertarNuevo(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TICKET_ENTREGA", ticket);
            comando.Parameters.AddWithValue("@NO_CLIENTE", cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", tecnico);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@FECHA_ENTREGA", fecha);
            comando.Parameters.AddWithValue("@TRABAJO_REALIZADO", trabajo);
            comando.Parameters.AddWithValue("@REPUESTO", repuesto);
            comando.Parameters.AddWithValue("@GARANTIA", garantia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA EDITAR TODOS LOS DATOS DE LAS ENTREGAS
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        /// <param name="no_entrega"></param>
        public void EditarNuevo(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia, string no_entrega)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TICKET_ENTREGA", ticket);
            comando.Parameters.AddWithValue("@NO_CLIENTE", cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", tecnico);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@FECHA_ENTREGA", fecha);
            comando.Parameters.AddWithValue("@TRABAJO_REALIZADO", trabajo);
            comando.Parameters.AddWithValue("@REPUESTO", repuesto);
            comando.Parameters.AddWithValue("@GARANTIA", garantia);
            comando.Parameters.AddWithValue("@NO_ENTREGA", no_entrega);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA ELIMINAR TODOS LOS DATOS DE LAS ENTREGAS
        /// </summary>
        /// <param name="no_entrega"></param>
        public void EliminarNuevo(string no_entrega)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_ENTREGA", no_entrega);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    } 
}
