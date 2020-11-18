using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using ConexionSql;

namespace clsNegocios
{
    public class clsCliente
    {
        public string id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ultima_compra { get; set; }
        public string puntos { get; set; }

        public string mensaje { get; set; }
        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_comprobar_puntos = "pa_comprobar_puntos";
        private DataTable clientesPunt;

        public clsCliente comprobarPuntos(string cod)
        {
            Conexion con = new Conexion();
            param.Add("cod");
            campos.Add(cod);
            this.clientesPunt = con.proceder(pa_comprobar_puntos, param, campos);
            clsCliente devuelve = new clsCliente();
            if (!con.error)
            {
                foreach (DataRow row in this.clientesPunt.Rows)
                {
                    devuelve.nombre = row["nombre"].ToString();
                    devuelve.apellido = row["apellido"].ToString();
                    devuelve.puntos = row["puntos"].ToString();
                }
                this.mensaje = "ok";
            }
            else
            {
                devuelve.id_cliente = "0";
                devuelve.mensaje = con.MensjError;
            }
            return devuelve;
        }
    }
}
