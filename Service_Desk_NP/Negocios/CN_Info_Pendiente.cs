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
    public class CN_Info_Pendiente
    {
        private CD_Info_Pendiente objetoCD = new CD_Info_Pendiente();

        public DataTable MostrarPendiente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}