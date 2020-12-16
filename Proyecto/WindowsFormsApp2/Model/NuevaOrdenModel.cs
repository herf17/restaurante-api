using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2.Model
{
    class NuevaOrdenModel
    {
        public string total { get; set; }
        public string iduser { get; set; }
        public string mesa { get; set; }
        public string idclient { get; set; }

        public List<ProductosEnOrdenModel> productos { get; set; }
    }
}
