using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CD_Conexion
    {
        private SqlConnection ConexionSQL = new SqlConnection(@"server=                (local)\sqlexpress;" +
                                                                " DataBase=             BD_SERVICE_DESK;" +
                                                                " Integrated Security=  true");

        public SqlConnection AbrirConexion()
        {
            if (ConexionSQL.State == ConnectionState.Closed)
                ConexionSQL.Open();
            return ConexionSQL;
        }
        public SqlConnection CerrarConexion()
        {
            if (ConexionSQL.State == ConnectionState.Open)
                ConexionSQL.Close();
            return ConexionSQL;
        }
    }
}
