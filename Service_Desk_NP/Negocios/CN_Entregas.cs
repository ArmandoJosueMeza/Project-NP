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
    public class CN_Entregas
    {
        private CD_Entregas objetoCD = new CD_Entregas();

        public DataTable MostrarEntregas(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtrado, criterio);
            return tabla;
        }

        public void InsertarEntregas(string no_ticket, string no_cliente, string no_serie, string no_tecnico, int estado, string fecha, string trabajo_realizado, string repuesto, string garantia)
        {
            objetoCD.Insertar(no_ticket, no_cliente, no_serie, no_tecnico, estado, fecha, trabajo_realizado, repuesto, garantia);
        }

        public void EditarEntregas(string no_ticket, string no_cliente, string no_serie, string no_tecnico, int estado, string fecha, string trabajo_realizado, string repuesto, string garantia, string no_entrega)
        {
            objetoCD.Editar(no_ticket, no_cliente, no_serie, no_tecnico, estado, fecha, trabajo_realizado, repuesto, garantia, no_entrega);
        }

        public void EliminarEntregas(string no_entrega)
        {
            objetoCD.Eliminar(no_entrega);
        }
    }
}
