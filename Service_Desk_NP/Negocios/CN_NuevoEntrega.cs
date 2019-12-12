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
    public class CN_NuevoEntrega
    {
        private CD_NuevoEntrega objetoCD = new CD_NuevoEntrega();

        public DataTable MostrarNuevoEntregas(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarNuevo(filtrado, criterio);
            return tabla;
        }

        public void InsertarNuevoEntregas(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia)
        {
            objetoCD.InsertarNuevo(ticket, cliente, serie, tecnico, estado, fecha, trabajo, repuesto, garantia);
        }

        public void EditarNuevoEntregas(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia, string no_entrega)
        {
            objetoCD.EditarNuevo(ticket, cliente, serie, tecnico, estado, fecha, trabajo, repuesto, garantia, no_entrega);
        }

        public void EliminarEntregas(string no_entrega)
        {
            objetoCD.EliminarNuevo(no_entrega);
        }
    }
}
