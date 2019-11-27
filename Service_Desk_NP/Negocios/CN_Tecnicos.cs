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

        public DataTable MostrarTecnicos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarTecnicos(string nombre, string apellido, string telefono, string correo)
        {
            objetoCD.Insertar(nombre, apellido, telefono, correo);
        }

        public void EditarTecnicos(string nombre, string apellido, string telefono, string correo, string no_tecnico)
        {
            objetoCD.Editar(nombre, apellido, telefono, correo, no_tecnico);
        }

        public void EliminarTecnicos(string no_tecnico)
        {
            objetoCD.Eliminar(no_tecnico);
        }
    }
}
