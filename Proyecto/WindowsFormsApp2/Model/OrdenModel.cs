using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2.Model
{
    class OrdenModel
    {
        public string id_orden { get; set; }
        public string fecha_orden { get; set; }
        public string total { get; set; }
        public string id_usuario { get; set; }
        public string numero_mesa { get; set; }
        public string id_cliente { get; set; }
    }
}
