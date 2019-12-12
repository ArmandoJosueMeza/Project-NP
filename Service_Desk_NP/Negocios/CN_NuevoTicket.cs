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

        public DataTable MostrarNuevoTickets(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarNuevo(filtrado, criterio);
            return tabla;
        }

        public void InsertarNuevoTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones)
        {
            objetoCD.InsertarNuevo(cliente, serie, tecnico, fecha, estado, problema, observaciones);
        }

        public void EditarNuevoTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones, string no_ticket)
        {
            objetoCD.EditarNuevo(cliente, serie, tecnico, fecha, estado, problema, observaciones, no_ticket);
        }

        public void EliminarTickets(string no_ticket)
        {
            objetoCD.EliminarNuevo(no_ticket);
        }
    }
}
