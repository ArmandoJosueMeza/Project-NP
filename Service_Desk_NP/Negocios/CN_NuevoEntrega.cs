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
        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA TABLA ENTREGAS
        /// </summary>
        /// <param name="filtrado"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarNuevoEntregas(string filtrado, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarNuevo(filtrado, criterio);
            return tabla;
        }
        /// <summary>
        /// SE ENCARGA DE INSERTAR LOS DATOS EN LA TABLA ENTREGAS 
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        public void InsertarNuevoEntregas(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia)
        {
            objetoCD.InsertarNuevo(ticket, cliente, serie, tecnico, estado, fecha, trabajo, repuesto, garantia);
        }
        /// <summary>
        /// SE ENCARGA DE EDITAR LOS DATOS EN LA TABLA ENTREGAS 
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="cliente"></param>
        /// <param name="serie"></param>
        /// <param name="tecnico"></param>
        /// <param name="estado"></param>
        /// <param name="fecha"></param>
        /// <param name="trabajo"></param>
        /// <param name="repuesto"></param>
        /// <param name="garantia"></param>
        /// <param name="no_entrega"></param>
        public void EditarNuevoEntregas(string ticket, string cliente, string serie, string tecnico, int estado, string fecha, string trabajo, string repuesto, string garantia, string no_entrega)
        {
            objetoCD.EditarNuevo(ticket, cliente, serie, tecnico, estado, fecha, trabajo, repuesto, garantia, no_entrega);
        }
        /// <summary>
        /// SE ENCARGA DE ELIMINAR LOS DATOS EN LA TABLA ENTREGAS 
        /// </summary>
        /// <param name="no_entrega"></param>
        public void EliminarEntregas(string no_entrega)
        {
            objetoCD.EliminarNuevo(no_entrega);
        }
    }
}
