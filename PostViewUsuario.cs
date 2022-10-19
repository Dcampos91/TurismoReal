using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo
{
    public class PostViewUsuario
    {
        public int ID_USUARIO { get; set; }
        public string NOM_USUARIO { get; set; }
        public string CORREO_USUARIO { get; set; }
        public string CONTRASENIA { get; set; }
        public char ESTADO_USUARIO { get; set; }
        public int TIPO_USUARIO_ID_TIPO_USUARIO { get; set; }
    }
}
