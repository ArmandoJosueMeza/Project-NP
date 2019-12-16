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
using Soporte.Cache;

namespace Datos
{
    /// <summary>
    /// SE ENCAGARA DE OBTENER LA INFORMACION DEL USUARIO
    /// CREADO EN LA BASE DE DATOS:  BD_SERVICE_DESK
    /// </summary>
    /// </summary>
    public class CD_UsuarioDAO
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /// <summary>
        /// MUESTRA LOS DATOS DEL CLIENTE MIENTRAS ESTE EN INICIO DE SESION
        /// </summary>
        /// <param name="nombre_login"></param>
        /// <param name="clave_login"></param>
        /// <returns></returns>
        public bool Login(string nombre_login, string clave_login)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Personas.Usuario WHERE Nombre_Login = @NOMBRE_LOGIN AND Clave_Login = @CLAVE_LOGIN";
            comando.Parameters.AddWithValue("@NOMBRE_LOGIN", nombre_login);
            comando.Parameters.AddWithValue("@CLAVE_LOGIN", clave_login);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //UsuarioLoginCache.nombre_login = reader.GetString(2);
                    UsuarioLoginCache.nombre_usuario = reader.GetString(4);
                    UsuarioLoginCache.apellido_usuario = reader.GetString(5);
                    UsuarioLoginCache.puesto_usuario = reader.GetString(6);
                    UsuarioLoginCache.correo_usuario = reader.GetString(7);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
