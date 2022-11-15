using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismo
{
    public class PostViewInventario
    {
        public int ID_INVENTARIO { get; set; }
        public string FECHA_INVENTARIO { get; set; }
        public int CANT_PRODUCTO_INVENTARIO { get; set; }
        public int VALOR_ESTIMADO { get; set; }
        public string DESCRIPCION_INVENTARIO { get; set; }
        public int DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
        public int PRODUCTO_ID_PRODUCTO { get; set; }
    }
}
