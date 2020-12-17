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

        // variales para procedimientos almacenados de la Tabla Cliente -- CRUD de Mantenimiento 
        private string sp_tbl_cliente_insert = "sp_tbl_cliente_insert";
        private string sp_tbl_cliente_update = "sp_tbl_cliente_update";
        private string sp_tbl_cliente_select_uno = "sp_tbl_cliente_select_uno";
        private string sp_tbl_cliente_select = "sp_tbl_cliente_select";
      
        private DataTable listado;

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


        public clsCliente insertCliente()
        {
            Conexion con = new Conexion();
            param.Add("p_nombre");
            param.Add("p_apellido");
            param.Add("p_ultima_compra");
            param.Add("p_puntos");

            campos.Add(this.nombre);
            campos.Add(this.apellido);
            campos.Add(this.ultima_compra);
            campos.Add(this.puntos);

            this.listado = con.proceder(sp_tbl_cliente_insert, param, campos);

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_cliente = row["id_cliente"].ToString();
                    this.mensaje = "OK";
                }
            }
            else
            {
                this.id_cliente = "0";
                this.mensaje = con.MensjError;
            }

            return this;

        }

        public clsCliente updateCliente()
        {
            Conexion con = new Conexion();

            param.Add("p_id_cliente");
            param.Add("p_nombre");
            param.Add("p_apellido");
            param.Add("p_ultima_compra");
            param.Add("p_puntos");

            campos.Add(this.id_cliente);
            campos.Add(this.nombre);
            campos.Add(this.apellido);
            campos.Add(this.ultima_compra);
            campos.Add(this.puntos);

        this.listado = con.proceder(sp_tbl_cliente_update, param, campos);
            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_cliente = row["actualizado"].ToString();
                    this.mensaje = "OK";
                }
            else
            {
                this.id_cliente = "0";
                this.mensaje = con.MensjError;
            }

            return this;
        }


        public List<clsCliente> BuscarCliente()
        {
            Conexion con = new Conexion();
            param.Add("p_id_cliente");
            campos.Add(this.id_cliente);

            this.listado = con.proceder(sp_tbl_cliente_select_uno, param, campos);
            List<clsCliente> lista = new List<clsCliente>();
            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsCliente
                    {
                        id_cliente    = row["id_cliente"].ToString(),
                        nombre        = row["nombre"].ToString(),
                        apellido      = row["apellido"].ToString(),
                        ultima_compra = row["ultima_compra"].ToString(),
                        puntos        = row["puntos"].ToString()
                    });
                }
            return lista;
        }

        public List<clsCliente> TodosClientes()
        {
            Conexion con = new Conexion();

            this.listado = con.proceder(sp_tbl_cliente_select, param, campos);

            List<clsCliente> lista = new List<clsCliente>();

            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsCliente
                    {
                        id_cliente    = row["id_cliente"].ToString(),
                        nombre        = row["nombre"].ToString(),
                        apellido      = row["apellido"].ToString(),
                        ultima_compra = row["ultima_compra"].ToString(),
                        puntos        = row["puntos"].ToString()
                    });
               
                }
            return lista;
        }
    }
}
