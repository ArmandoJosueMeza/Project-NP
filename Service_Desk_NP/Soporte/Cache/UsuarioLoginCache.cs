using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class UsuarioLoginCache
    {
        public static string nombre_login { get; set; }
        public static string nombre_usuario { get; set; }
        public static string apellido_usuario { get; set; }
        public static string puesto_usuario { get; set; }
        public static string correo_usuario { get; set; }
    }
}
