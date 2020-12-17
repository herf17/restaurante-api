using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Model
{
    class UsuariosModel
    {
        public string id_usuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string activo { get; set; }
        public string fecha_adicion { get; set; }
        public string fecha_modificacion { get; set; }

        public string mensaje { get; set; }
    }
}
