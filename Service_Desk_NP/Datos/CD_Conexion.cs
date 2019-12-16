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
    /// CLASE CONEXION PARA ENLAZAR LA BASE DE DATOS: BD_SERVICE_DESK
    /// AL SOFTWARE SERVICE DESK DE NETWORK PLACE STD
    /// </summary>
    public class CD_Conexion
    {
        /// <summary>
        /// ESTABLECER LOS PARAMETROS DE CONEXION CON LA BASE DE DATOS 
        /// </summary>
        private SqlConnection ConexionSQL = new SqlConnection(@"Server=               (local)\SQLEXPRESS;" +
                                                               "DataBase=             BD_SERVICE_DESK;" +
                                                               "Integrated Security=  true");

        /// <summary>
        /// METODO PARA ACCEDER Y ABRIR LA CONEXION DE LA BASE DE DATOS
        /// </summary>
        /// <returns></returns>
        public SqlConnection AbrirConexion()
        {
            if (ConexionSQL.State == ConnectionState.Closed)
                ConexionSQL.Open();
            return ConexionSQL;
        }
        /// <summary>
        /// METODO PARA CERRAR LA CONEXION CON LA BASE DE DATOS
        /// </summary>
        /// <returns></returns>
        public SqlConnection CerrarConexion()
        {
            if (ConexionSQL.State == ConnectionState.Open)
                ConexionSQL.Close();
            return ConexionSQL;
        }

    }
}
