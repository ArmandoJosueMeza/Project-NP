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
    public class CN_Tecnicos
    {
        private CD_Tecnicos objetoCD = new CD_Tecnicos();
        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA TABLA TECNICOS
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarTecnicos(string filtro, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtro, criterio);
            return tabla;
        }

        /// <summary>
        /// SE ENCARGA DE INSERTAR LOS DATOS EN LA TABLA TECNICOS
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        public void InsertarTecnicos(string nombre, string apellido, string telefono, string correo)
        {
            objetoCD.Insertar(nombre, apellido, telefono, correo);
        }
        /// <summary>
        /// SE ENCARGA DE EDITAR LOS DATOS EN LA TABLA TECNICOS
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="no_tecnico"></param>
        public void EditarTecnicos(string nombre, string apellido, string telefono, string correo, string no_tecnico)
        {
            objetoCD.Editar(nombre, apellido, telefono, correo, no_tecnico);
        }
        /// <summary>
        /// SE ENCARGA DE ELIMINAR LOS DATOS EN LA TABLA TECNICOS
        /// </summary>
        /// <param name="no_tecnico"></param>
        public void EliminarTecnicos(string no_tecnico)
        {
            objetoCD.Eliminar(no_tecnico);
        }
    }
}
