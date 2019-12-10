using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;


namespace Negocios
{
    public class CN_Usuario
    {
        private CD_UsuarioDAO UsuarioDAO = new CD_UsuarioDAO();

        public bool Inicio_Sesion(string nombre_login, string clave_login)
        {
            return UsuarioDAO.Login(nombre_login, clave_login);
        }
    }
}
