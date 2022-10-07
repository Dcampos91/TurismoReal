using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Models.Request
{
    internal class ClienteRequest
    {
        public string rut_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public int edad { get; set; }
        public string nacionalidad { get; set; }
        public string genero { get; set; }
        public string direccion_cliente { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public int usuario_id_usuario { get; set; }
    }
}
