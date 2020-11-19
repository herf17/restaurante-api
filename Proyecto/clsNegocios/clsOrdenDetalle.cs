using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using ConexionSql;

namespace clsNegocios
{
    public class clsOrdenDetalle
    {
        public string id_orden { get; set; }
        public string id_producto { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string total { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_insertOrdenDetalle = "pa_insert_orden_detalle";

        public void insertarDetalleOrden(string idOrden, string idProduc, string cant, string prec, string tot)
        {
            Conexion conexion = new Conexion();
            param.Add("idorden");
            param.Add("idproducto");
            param.Add("cantidad");
            param.Add("precio");
            param.Add("total");
            campos.Add(idOrden);
            campos.Add(idProduc);
            campos.Add(cant);
            campos.Add(prec);
            campos.Add(tot);

            conexion.proceder(pa_insertOrdenDetalle, param, campos);
        }
    }
}
