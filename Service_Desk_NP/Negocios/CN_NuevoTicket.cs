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
    public class CN_NuevoTicket
    {
        private CD_NuevoTicket objetoCD = new CD_NuevoTicket();
        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA TABLA TICKETS 
        /// </summary>
        /// <param name="filtrado"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarNuevoTickets(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarNuevo(filtrado, criterio);
            return tabla;
        }
        /// <summary>
        /// SE ENCARGA DE INSERTAR LOS DATOS EN LA TABLA TICKETS 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <param name="problema"></param>
        /// <param name="observaciones"></param>
        public void InsertarNuevoTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones)
        {
            objetoCD.InsertarNuevo(cliente, serie, tecnico, fecha, estado, problema, observaciones);
        }
        /// <summary>
        /// SE ENCARGA DE EDITAR LOS DATOS EN LA TABLA TICKETS 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <param name="problema"></param>
        /// <param name="observaciones"></param>
        /// <param name="no_ticket"></param>
        public void EditarNuevoTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones, string no_ticket)
        {
            objetoCD.EditarNuevo(cliente, serie, tecnico, fecha, estado, problema, observaciones, no_ticket);
        }
        /// <summary>
        /// SE ENCARGA DE ELIMINAR LOS DATOS EN LA TABLA TICKETS 
        /// </summary>
        /// <param name="no_ticket"></param>
        public void EliminarTickets(string no_ticket)
        {
            objetoCD.EliminarNuevo(no_ticket);
        }
    }
}
