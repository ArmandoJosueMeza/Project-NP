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
    /// CLASE CLIENTES 
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD CLIENTES
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DEL CLIENTE 
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable Mostrar(string tipo_filtro="TODOS", string criterio="")
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TIPO_FILTRO", tipo_filtro);
            comando.Parameters.AddWithValue("@CRITERIO", criterio);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA INSERTAR LOS DATOS DEL CLIENTE 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="empresa"></param>
        /// <param name="ubicacion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
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
            comando.Parameters.Clear();
        }
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA EDITAR LOS DATOS DEL CLIENTE 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="empresa"></param>
        /// <param name="ubicacion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="no_cliente"></param>
        public void Editar(string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo, string no_cliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", nombre);
            comando.Parameters.AddWithValue("@APELLIDO_CLIENTE", apellido);
            comando.Parameters.AddWithValue("@EMPRESA", empresa);
            comando.Parameters.AddWithValue("@UBICACION", ubicacion);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.Parameters.AddWithValue("@CORREO", correo);
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA ELIMINAR LOS DATOS DEL CLIENTE 
        /// </summary>
        /// <param name="no_cliente"></param>
        public void Eliminar(string no_cliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ELIMINAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
