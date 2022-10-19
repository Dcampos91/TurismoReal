using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Turismo
{
    public class PostViewDepartamento
    {
        public int ID_DEPTO { get; set; }
        public string NOM_DEPTO { get; set; }
        public string DESC_DEPTO { get; set; }
        public string DIRECCION { get; set; }
        public int CANT_HABITACION { get; set; }
        public int CANT_BANIO { get; set; }        
        public string CALEFACCION { get; set; }
        public string INTERNET { get; set; }
        public string AMOBLADO { get; set; }
        public string TELEVISION { get; set; }
        public string DISPONIBLE { get; set; }
        public int VALOR_DIA { get; set; }
        public int COMUNA_ID_COMUNA { get; set; }
    }
    
}
