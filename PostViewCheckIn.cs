using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo
{
    internal class PostViewCheckIn
    {
        public int ID_CHECK_IN { get; set; }
        public string FECHA_CHECK_IN { get; set; }
        public string OBSERVACION { get; set; }
        public int RESERVA_ID_RESERVA { get; set; }
    }
}
