using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Turismo
{
    public class PostViewCliente
    {
        public string RUT_CLIENTE { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERMO { get; set; }
        public int EDAD { get; set; }
        public string NACIONALIDAD { get; set; }
        public string GENERO { get; set; }
        public string DIRECCION_CLIENTE { get; set; }
        public int TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public int USUARIO_ID_USUARIO { get; set; }
        
    }
}
