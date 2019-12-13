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
    /// CLASE INFORMACION DE TICKETS FINALIZADOS 
    /// SE ENCAGARA DE OBTENER LA INFORMACION DE LOS TICKETS FINALIZADOS
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    public class CD_Info_Finalizado
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        /// <summary>
        /// OBTIENE EL PROCEDIMIENTO PARA MOSTRAR TODOS LOS TICKETS FINALIZADOS
        /// </summary>
        /// <returns></returns>
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_MOSTRAR_FINALIZADO";
            comando.CommandType = CommandType.StoredProcedure;
            
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
