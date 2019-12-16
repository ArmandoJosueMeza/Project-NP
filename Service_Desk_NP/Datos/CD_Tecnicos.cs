﻿using System;
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
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD TECNICOS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_Tecnicos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        ///  OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DE LOS TECNICOS
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable Mostrar(string tipo_filtro = "TODOS", string criterio = "")
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_TECNICO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TIPO_FILTRO", tipo_filtro);
            comando.Parameters.AddWithValue("@CRITERIO", criterio);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        /// <summary>
        ///  OBTIENE EL PROCEDIMIENTO PARA INSERTAR TODOS LOS DATOS DE LOS TECNICOS
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
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
        /// <summary>
        ///  OBTIENE EL PROCEDIMIENTO PARA EDITAR TODOS LOS DATOS DE LOS TECNICOS
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="no_tecnico"></param>
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
        /// <summary>
        ///  OBTIENE EL PROCEDIMIENTO PARA ELIMINAR TODOS LOS DATOS DE LOS TECNICOS
        /// </summary>
        /// <param name="no_tecnico"></param>
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
