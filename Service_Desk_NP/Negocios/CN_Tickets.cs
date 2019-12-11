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
    public class CN_Tickets
    {
        private CD_Tickets objetoCD = new CD_Tickets();

        public DataTable MostrarTickets(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtrado, criterio);
            return tabla;
        }

        public void InsertarTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones)
        {
            objetoCD.Insertar(cliente, serie, tecnico, fecha, estado, problema, observaciones);
        }

        public void EditarTickets(string cliente, string serie, string tecnico, string fecha, int estado, string problema, string observaciones, string no_ticket)
        {
            objetoCD.Editar(cliente, serie, tecnico, fecha, estado, problema, observaciones, no_ticket);

        }

        public void EliminarTickets(string no_ticket)
        {
            objetoCD.Eliminar(no_ticket);
        }
    }
}
