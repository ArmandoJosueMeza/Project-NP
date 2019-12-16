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
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        /// <summary>
        /// SE ENCARGA DE LEER LOS DATOS EN LA TABLA CLIENTES 
        /// </summary>
        /// <param name="filtro"></param>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public DataTable MostrarClientes(string filtro, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtro, criterio);
            return tabla;
        }

        /// <summary>
        /// SE ENCARGA DE INSERTAR DE LOS DATOS EN LA TABLA CLIENTES 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="empresa"></param>
        /// <param name="ubicacion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        public void InsertarCliente (string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo)
        {
            objetoCD.Insertar(nombre, apellido, empresa, ubicacion, telefono, correo);
        }

        /// <summary>
        /// SE ENCARGA DE EDITAR LOS DATOS EN LA TABLA CLIENTES 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="empresa"></param>
        /// <param name="ubicacion"></param>
        /// <param name="telefono"></param>
        /// <param name="correo"></param>
        /// <param name="no_cliente"></param>
        public void EditarClientes(string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo, string no_cliente)
        {
            objetoCD.Editar(nombre, apellido, empresa, ubicacion, telefono, correo, no_cliente);

        }

        /// <summary>
        /// SE ENCARGA DE ELIMINAR LOS DATOS EN LA TABLA CLIENTES 
        /// </summary>
        /// <param name="no_cliente"></param>
        public void EliminarClientes(string no_cliente)
        {
            objetoCD.Eliminar(no_cliente);
        }

    }
}
