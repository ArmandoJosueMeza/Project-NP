﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocios
{
    public class CN_Info_Finalizado
    {
        private CD_Info_Finalizado objetoCD = new CD_Info_Finalizado();
        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN VISTA TICKETS FINALIZADOS 
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarFinalizado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}
