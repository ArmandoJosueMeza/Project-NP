using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// IMPORTACION DE LA CLASES PARA 
/// LA CONEXION CON LA BASE DE DATOS 
/// EN SQL SERVER 
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    /// <summary>
    /// CLASE EQUIPOS
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD EQUIPOS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_Equipos
    {
      
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DE LOS EQUIPOS
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable Mostrar(string tipo_filtro = "TODOS", string criterio = "")
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TIPO_FILTRO", tipo_filtro);
            comando.Parameters.AddWithValue("@CRITERIO", criterio);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA INSERTAR TODOS LOS DATOS DE EQUIPOS
        /// </summary>
        /// <param name="no_cliente"></param>
        /// <param name="equipo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="no_serie"></param>
        /// <param name="clave_acceso"></param>
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

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA EDITAR TODOS LOS DATOS DE EQUIPOS
        /// </summary>
        /// <param name="no_cliente"></param>
        /// <param name="equipo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="no_serie"></param>
        /// <param name="clave_acceso"></param>
        /// <param name="no_equipo"></param>
        public void Editar(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso, string no_equipo)
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
            comando.Parameters.AddWithValue("@NO_EQUIPO", no_equipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA ELIMINAR TODOS LOS DATOS DE EQUIPOS
        /// </summary>
        /// <param name="no_equipo"></param>
        public void Eliminar(string no_equipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_EQUIPO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_EQUIPO", no_equipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
