using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using ConexionSql;

namespace clsNegocios
{
    public class clsOrdenEncabezado
    {
        public string id_orden { get; set; }
        public string fecha_orden { get; set; }
        public string total { get; set; }
        public string id_usuario { get; set; }
        public string numero_mesa { get; set; }
        public string id_cliente { get; set; }
        public string estado { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_newOrden = "pa_crear_orden";
        private DataTable idOrden;

        public string IdParaNuevaOrden( string precioTotal, string idUser, string numeroMesa, string idClient)
        {
            Conexion conexion = new Conexion();
            param.Add("tota");
            param.Add("idusuario");
            param.Add("numeromesa");
            param.Add("idcliente");
            campos.Add(precioTotal);
            campos.Add(idUser);
            campos.Add(numeroMesa);
            campos.Add(idClient);
            this.idOrden = conexion.proceder(pa_newOrden, param, campos);
            if (!conexion.error)
            {
                foreach(DataRow fila in this.idOrden.Rows)
                {
                    this.id_orden = fila["id_orden"].ToString();
                }
            }
            return this.id_orden;
        }
        public void insertProductosDeOrden(string id)
        {

        }

    }
}
