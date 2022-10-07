using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo.Models.Request
{
    internal class DepartamentoRequest
    {
        public int id_departamento { get; set; }
        public string nom_depto { get; set; }
        public string desc_depto { get; set; }
        public string direccion { get; set; }
        public int cant_habitacion { get; set; }
        public int cant_banio { get; set; }
        public string calefaccion { get; set; }
        public string internet { get; set; }
        public string amoblado { get; set; }
        public string television { get; set; }
        public string disponible { get; set; }
        public int valor_dia { get; set; }
        public int comuna_id_comuna { get; set; }
    }
}
