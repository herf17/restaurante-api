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

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_OrdenCatg = "pa_select_orden_catg";
        private DataTable catgEnOrdenes;

        public List<clsCategorias> OrdenConCatg()
        {
            ClassConexion conexion = new ClassConexion();
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
    }
}
