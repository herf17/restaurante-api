using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiciosWebRestaurante.Model
{
    public class clsAgregarOrdenModel
    {
        public string total { get; set; }
        public string iduser { get; set; }
        public string mesa { get; set; }
        public string idclient { get; set; }

        public List<clsProducOrden> productos { get; set; }


    }
}
