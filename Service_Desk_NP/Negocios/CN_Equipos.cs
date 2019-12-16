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

        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA TABLA EQUIPOS 
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarEquipos(string filtro, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtro, criterio);
            return tabla;
        }
        /// <summary>
        ///  SE ENCARGA DE INSERTAR LOS DATOS EN LA TABLA EQUIPOS 
        /// </summary>
        /// <param name="no_cliente"></param>
        /// <param name="equipo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="no_serie"></param>
        /// <param name="clave_acceso"></param>
        public void InsertarEquipos(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso)
        {
            objetoCD.Insertar(no_cliente, equipo, marca, modelo, no_serie, clave_acceso);
        }

        /// <summary>
        ///  SE ENCARGA DE EDITAR LOS DATOS EN LA TABLA EQUIPOS 
        /// </summary>
        /// <param name="no_cliente"></param>
        /// <param name="equipo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="no_serie"></param>
        /// <param name="clave_acceso"></param>
        /// <param name="no_equipo"></param>
        public void EditarEquipos(string no_cliente, string equipo, string marca, string modelo, string no_serie, string clave_acceso, string no_equipo)
        {
            objetoCD.Editar(no_cliente, equipo, marca, modelo, no_serie, clave_acceso, no_equipo);
        }

        /// <summary>
        ///  SE ENCARGA DE ELIMINAR LOS DATOS EN LA TABLA EQUIPOS 
        /// </summary>
        /// <param name="no_equipo"></param>
        public void EliminarEquipos(string no_equipo)
        {
            objetoCD.Eliminar(no_equipo);
        }
    }

}
