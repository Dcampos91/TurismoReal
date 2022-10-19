using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Turismo.Models;

namespace Turismo
{
    public class PostViewMTTO
    {
        public DateTime FECHA_INGRESO { get; set; }
        public DateTime FECHA_SALIDA { get; set; }
        public string DESCRIPCION_MTTO { get; set; }
        public string DISPONIBILIDAD { get; set; }
        public int DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
        
    }
}
