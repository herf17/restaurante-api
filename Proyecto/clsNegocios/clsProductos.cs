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

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_CatgProduc = "pa_select_catg_prod";
        private DataTable producEnCatg;

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
                        precio = fila["precio"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
