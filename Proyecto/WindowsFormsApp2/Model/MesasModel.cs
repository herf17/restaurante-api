using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2.Model
{
    class MesasModel
    {
        public string numero { get; set; }
        public string descripcion { get; set; }

        public string estado { get; set; }
        public List<ProductosEnMesaModel> pror { get; set; }

    }
}
