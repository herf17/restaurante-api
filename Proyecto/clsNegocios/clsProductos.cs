using System;
using System.Collections.Generic;
using ConexionSql;
using System.Text;
using System.Collections;
using System.Data;

namespace clsNegocios
{
    public class clsProductos
    {
        public string id_producto { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public string id_categoria { get; set; }
        public string cantidad { get; set; }
        public string activo { get; set; } 
        public string mensaje { get; set; }

        private ArrayList param  = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_CatgProduc = "pa_select_catg_prod";
        private DataTable producEnCatg;

        // variales para procedimientos almacenados de la Tabla Productos -- CRUD de Mantenimiento 
        private string sp_tbl_productos_insert     = "sp_tbl_productos_insert";
        private string sp_tbl_productos_update     = "sp_tbl_productos_update";
        private string sp_tbl_productos_select_uno = "sp_tbl_productos_select_uno";
        private string sp_tbl_productos_select     = "sp_tbl_productos_select";

        private DataTable listado;

        public List<clsProductos> ProductoEnCatg(string id)
        {
            Conexion conexion = new Conexion();
            param.Add("id_categ");
            campos.Add(id);
            this.producEnCatg = conexion.proceder(pa_CatgProduc, param, campos);
            List<clsProductos> lista = new List<clsProductos>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.producEnCatg.Rows)
                {
                    lista.Add(new clsProductos
                    {
                        id_producto = fila["id_producto"].ToString(),
                        descripcion = fila["descripcion"].ToString(),
                        precio      = fila["precio"].ToString()
                    });
                }
            }
            return lista;
        }

        public clsProductos insertProductos()
        {
            ClassConexion con = new ClassConexion();
           
            param.Add("p_descripcion");
            param.Add("p_precio");
            param.Add("p_id_categoria");
            param.Add("p_cantidad");
            param.Add("p_activo");

            campos.Add(this.descripcion);
            campos.Add(this.precio);
            campos.Add(this.id_categoria);
            campos.Add(this.cantidad);
            campos.Add(this.activo);

            this.listado = con.proceder(sp_tbl_productos_insert, param, campos);

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_producto = row["id_producto"].ToString();
                    this.mensaje     = "OK";
                }
            }
            else
            {
                this.id_producto = "0";
                this.mensaje     = con.MensjError;
            }

            return this;

        }

        public clsProductos updateProductos()
        {
            ClassConexion con = new ClassConexion();

            param.Add("p_id_producto");
            param.Add("p_descripcion");
            param.Add("p_precio");
            param.Add("p_id_categoria");
            param.Add("p_cantidad");
            param.Add("p_activo");

            campos.Add(this.id_producto);
            campos.Add(this.descripcion);
            campos.Add(this.precio);
            campos.Add(this.id_categoria);
            campos.Add(this.cantidad);
            campos.Add(this.activo);

            this.listado = con.proceder(sp_tbl_productos_update, param, campos);
            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_producto = row["actualizado"].ToString();
                    this.mensaje     = "OK";
                }
            else
            {
                this.id_producto = "0";
                this.mensaje     = con.MensjError;
            }

            return this;
        }

        public List<clsProductos> BuscarProductos()
        {
            ClassConexion con = new ClassConexion();
            param.Add("p_id_producto");
            campos.Add(this.id_producto);

            this.listado = con.proceder(sp_tbl_productos_select_uno, param, campos);
            List<clsProductos> lista = new List<clsProductos>();
            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsProductos
                    {
                        id_producto  = row["id_producto"].ToString(),
                        descripcion  = row["descripcion"].ToString(),
                        precio       = row["precio"].ToString(),
                        id_categoria = row["id_categoria"].ToString(),
                        cantidad     = row["cantidad"].ToString(),
                        activo       = row["activo"].ToString()
                    });
                }
            return lista;
        }

        public List<clsProductos> TodosProductos()
        {
            ClassConexion con = new ClassConexion();

            this.listado = con.proceder(sp_tbl_productos_select, param, campos);

            List<clsProductos> lista = new List<clsProductos>();

            if (!con.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsProductos
                    {
                        id_producto  = row["id_producto"].ToString(),
                        descripcion  = row["descripcion"].ToString(),
                        precio       = row["precio"].ToString(),
                        id_categoria = row["id_categoria"].ToString(),
                        cantidad     = row["cantidad"].ToString(),
                        activo       = row["activo"].ToString()
                    });

                }
            return lista;
        }
    }
}
