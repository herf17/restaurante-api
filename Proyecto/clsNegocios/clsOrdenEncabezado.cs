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


        public string mensaje { get; set; }
        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_newOrden = "pa_crear_orden";
        private string pa_denegar_orden = "pa_anular_orden";
        private string pa_end_orden = "pa_end_orden";
        private string pa_cambio_estado = "pa_cambio_estado_orden";
        private string pa_agregar_puntos = "pa_agregar_puntos";
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
        public string cancelarOrden(string id)
        {
            Conexion con = new Conexion();
            param.Add("idorden");
            campos.Add(id);
            this.idOrden = con.proceder(pa_denegar_orden, param, campos);
            if (!con.error)
            {
                
                this.mensaje = "ok";
            }
            else
            {
                this.mensaje = con.MensjError;
            }
            return this.mensaje;
        }
        public string endOrden(string id)
        {
            Conexion con = new Conexion();
            param.Add("idorden");
            campos.Add(id);
            this.idOrden = con.proceder(pa_end_orden, param, campos);
            DataTable data = new Conexion().proceder(pa_agregar_puntos, param, campos);
            if (!con.error)
            {

                this.mensaje = "ok";
            }
            else
            {
                this.mensaje = con.MensjError;
            }
            return this.mensaje;
        }
        public string cambioestado(string id)
        {
            Conexion con = new Conexion();
            param.Add("codmesa");
            campos.Add(id);
            this.idOrden = con.proceder(pa_cambio_estado, param, campos);
            if (!con.error)
            {

                this.mensaje = "ok";
            }
            else
            {
                this.mensaje = con.MensjError;
            }
            return this.mensaje;
        }

    }
}
