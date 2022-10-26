using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Turismo
{
    public class PostViewReserva
    {
        public int ID_RESERVA { get; set;}
        public string FECHA_INGRESO { get; set; }
        public string FECHA_SALIDA { get; set; }
        public int CANT_DIA_RESERVA { get; set; }
        public string ESTADO_RESERVA { get; set; }
        public string FECHA_ESTADO_RESERVA { get; set; }
        public int DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
        public int USUARIO_ID_USUARIO { get; set; }
    }
    
}
