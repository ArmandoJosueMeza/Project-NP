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
    public class CN_Equipos
    {
        private CD_Equipos objetoCD = new CD_Equipos();

        public DataTable MostrarEquipos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarEquipos(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso)
        {
            objetoCD.Insertar(no_cliente, equipo, marca, modelo, no_serie, clave_acceso);
        }

        public void EditarEquipos(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso, string no_equipo)
        {
            objetoCD.Editar(no_cliente, equipo, marca, modelo, no_serie, clave_acceso, no_equipo);
        }

        public void EliminarEquipos(string no_equipo)
        {
            objetoCD.Eliminar(no_equipo);
        }
    }

}
