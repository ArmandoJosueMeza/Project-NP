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
    public class CN_Info_Proceso
    {
        private CD_Info_Proceso objetoCD = new CD_Info_Proceso();
        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA VISTA TICKETS EN PROCESO
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarProceso()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}
