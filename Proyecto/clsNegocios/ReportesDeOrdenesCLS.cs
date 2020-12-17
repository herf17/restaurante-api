using System;
using System.Collections.Generic;
using ConexionSql;
using System.Text;
using System.Collections;
using System.Data;

namespace clsNegocios
{
    public class ReportesDeOrdenesCLS
    {
        public string id_orden { get; set; }
        public string fecha_hora { get; set; }
        public string total { get; set; }
        public string nombre { get; set; }
        public string numero { get; set; }
        public string estado { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string sp_SReporte_orden = "sp_select_reporte_de_ordenes";
        private DataTable mesas;

        public List<ReportesDeOrdenesCLS> ReporteOrdenes()
        {
            Conexion conexion = new Conexion();
            this.mesas = conexion.proceder(sp_SReporte_orden, param, campos);
            List<ReportesDeOrdenesCLS> lista = new List<ReportesDeOrdenesCLS>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.mesas.Rows)
                {
                    lista.Add(new ReportesDeOrdenesCLS
                    {
                        id_orden = fila["id_orden"].ToString(),
                        fecha_hora = fila["fecha_hora"].ToString(),
                        total = fila["estado"].ToString(),
                        nombre = fila["nombre"].ToString(),
                        numero = fila["numero"].ToString(),
                        estado = fila["estado"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
