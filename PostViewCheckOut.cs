using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo
{
    public class PostViewCheckOut
    {
        public int ID_CHECK_OUT { get; set; }
        public string FECHA_CHECK_OUT { get; set; }
        public string OBSERVACION { get; set; }
        public int RESERVA_ID_RESERVA { get; set; }
        public int? MULTA_ID_MULTA { get; set; }
        
    }
}
