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
    /// CLASE ENTREGAS
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL CRUD ENTREGAS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_Entregas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS DATOS DE ENTREGAS
        /// </summary>
        /// <param name="tipo_filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable Mostrar(string tipo_filtro = "TODOS", string criterio = "")
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
        /// OBTIENE EL PROCEDIMIENTO PARA INSERTAR LOS DATOS DE ENTREGAS
        /// </summary>
        /// <param name="no_ticket"></param>
        /// <param name="no_cliente"></param>
        /// <param name="no_serie"></param>
        /// <param name="no_tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo_realizado"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        public void Insertar(string no_ticket, string no_cliente, string no_serie, string no_tecnico, int estado, string fecha, string trabajo_realizado, string repuesto, string garantia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_AGREGAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TICKET_ENTREGA", no_ticket);
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", no_tecnico);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@FECHA_ENTREGA", fecha);
            comando.Parameters.AddWithValue("@TRABAJO_REALIZADO", trabajo_realizado);
            comando.Parameters.AddWithValue("@REPUESTO", repuesto);
            comando.Parameters.AddWithValue("@GARANTIA", garantia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA EDITAR LOS DATOS DE ENTREGAS
        /// </summary>
        /// <param name="no_ticket"></param>
        /// <param name="no_cliente"></param>
        /// <param name="no_serie"></param>
        /// <param name="no_tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo_realizado"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        /// <param name="no_entrega"></param>
        public void Editar(string no_ticket, string no_cliente, string no_serie, string no_tecnico, int estado, string fecha, string trabajo_realizado, string repuesto, string garantia, string no_entrega)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_ACTUALIZAR_ENTREGA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NO_TICKET_ENTREGA", no_ticket);
            comando.Parameters.AddWithValue("@NO_CLIENTE", no_cliente);
            comando.Parameters.AddWithValue("@NO_SERIE", no_serie);
            comando.Parameters.AddWithValue("@NO_TECNICO_ASIGNADO", no_tecnico);
            comando.Parameters.AddWithValue("@ID_ESTADO", estado);
            comando.Parameters.AddWithValue("@FECHA_ENTREGA", fecha);
            comando.Parameters.AddWithValue("@TRABAJO_REALIZADO", trabajo_realizado);
            comando.Parameters.AddWithValue("@REPUESTO", repuesto);
            comando.Parameters.AddWithValue("@GARANTIA", garantia);
            comando.Parameters.AddWithValue("@NO_ENTREGA", no_entrega);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA ELIMINAR LOS DATOS DE ENTREGAS
        /// </summary>
        /// <param name="no_entrega"></param>
        public void Eliminar(string no_entrega)
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
