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

        public DataTable MostrarClientes(string filtro, string criterio)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(filtro, criterio);
            return tabla;
        }

        public void InsertarCliente (string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo)
        {
            objetoCD.Insertar(nombre, apellido, empresa, ubicacion, telefono, correo);
        }

        public void EditarClientes(string nombre, string apellido, string empresa, string ubicacion, string telefono, string correo, string no_cliente)
        {
            objetoCD.Editar(nombre, apellido, empresa, ubicacion, telefono, correo, no_cliente);

        }

        public void EliminarClientes(string no_cliente)
        {
            objetoCD.Eliminar(no_cliente);
        }

    }
}
