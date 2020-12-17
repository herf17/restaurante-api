using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;
using ConexionSql;

namespace clsNegocios
{
    public class clsCategorias
    {
        public string id_categoria { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; } 
        public string activo { get; set; }
        public string mensaje { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_OrdenCatg = "pa_select_orden_catg";
        private DataTable catgEnOrdenes;

        // variales para procedimientos almacenados de la Tabla Categoria -- CRUD de Mantenimiento 
        private string sp_tbl_categoria_insert     = "sp_tbl_categoria_insert";
        private string sp_tbl_categoria_update     = "sp_tbl_categoria_update";
        private string sp_tbl_categoria_select_uno = "sp_tbl_categoria_select_uno";
        private string sp_tbl_categoria_select     = "sp_tbl_categoria_select";

        private DataTable listado;

        public List<clsCategorias> OrdenConCatg()
        {
            Conexion conexion = new Conexion();
            this.catgEnOrdenes = conexion.proceder(pa_OrdenCatg, param, campos);
            List<clsCategorias> lista = new List<clsCategorias>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.catgEnOrdenes.Rows)
                {
                    lista.Add(new clsCategorias
                    {
                        id_categoria = fila["id_categoria"].ToString(),
                        nombre = fila["nombre"].ToString(),
                        imagen = fila["imagen"].ToString()
                    });
                }
            }
            return lista;
        }


        public clsCategorias insertCategoria()
        {
            Conexion con = new Conexion();
            param.Add("p_nombre");
            param.Add("p_imagen");
            param.Add("p_activo");

            campos.Add(this.nombre);
            campos.Add(this.imagen);
            campos.Add(this.activo);

            this.listado = con.proceder(sp_tbl_categoria_insert, param, campos);
            
            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_categoria = row["id_categoria"].ToString();
                    this.mensaje      = "OK";
                }
            }
            else
            {
                this.id_categoria = "0";
                this.mensaje      = con.MensjError;
            }

            return this;

        }
        public clsCategorias updateCategoria()
        {
            Conexion con = new Conexion();
            param.Add("p_id_categoria");
            param.Add("p_nombre");
            param.Add("p_imagen");
            param.Add("p_activo");

            campos.Add(this.id_categoria);
            campos.Add(this.nombre);
            campos.Add(this.imagen);
            campos.Add(this.activo);

            this.listado = con.proceder(sp_tbl_categoria_update, param, campos);

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    
                    this.id_categoria = row["actualizado"].ToString();
                    this.mensaje      = "OK";
                }
            }
            else
            {
                this.id_categoria = "0";
                this.mensaje      = con.MensjError;
            }

            return this;
        }


        public List<clsCategorias> BuscarCategorias()
        {
            Conexion con = new Conexion();
            param.Add("p_id_categoria");
            campos.Add(this.id_categoria);

            this.listado = con.proceder(sp_tbl_categoria_select_uno, param, campos);
            List<clsCategorias> lista = new List<clsCategorias>();
            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsCategorias
                    {
                        id_categoria = row["id_categoria"].ToString(),
                        nombre       = row["nombre"].ToString(),
                        imagen       = row["imagen"].ToString(),
                        activo       = row["activo"].ToString()
                    });
                }
            return lista;
        }

        public List<clsCategorias> TodosCategorias()
        {
            Conexion con = new Conexion();

            this.listado = con.proceder(sp_tbl_categoria_select, param, campos);

            List<clsCategorias> lista = new List<clsCategorias>();

            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsCategorias
                    {
                        id_categoria = row["id_categoria"].ToString(),
                        nombre       = row["nombre"].ToString(),
                        imagen       = row["imagen"].ToString(),
                        activo       = row["activo"].ToString()
                    });

                }
            return lista;
        }
    }
}
