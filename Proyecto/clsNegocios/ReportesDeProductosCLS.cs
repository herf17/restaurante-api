using System;
using System.Collections.Generic;
using ConexionSql;
using System.Text;
using System.Collections;
using System.Data;

namespace clsNegocios
{
    public class ReportesDeProductosCLS
    {
        public string id_producto { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public string id_categoria { get; set; }
        public string numero { get; set; }
        public string activo { get; set; }

        public string cantidad { get; set; }
        public string nombre { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string sp_SReporte_producto = "sp_select_reporte_de_producto";
        private DataTable mesas;

        public List<ReportesDeProductosCLS> ReporteProducto()
        {
            Conexion conexion = new Conexion();
            this.mesas = conexion.proceder(sp_SReporte_producto, param, campos);
            List<ReportesDeProductosCLS> lista = new List<ReportesDeProductosCLS>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.mesas.Rows)
                {
                    lista.Add(new ReportesDeProductosCLS
                    {
                        id_producto = fila["id_producto"].ToString(),
                        descripcion = fila["descripcion"].ToString(),
                        precio = fila["precio"].ToString(),
                        id_categoria = fila["id_categoria"].ToString(),
                        activo = fila["activo"].ToString(),
                        cantidad = fila["cantidad"].ToString(),
                        nombre = fila["nombre"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
