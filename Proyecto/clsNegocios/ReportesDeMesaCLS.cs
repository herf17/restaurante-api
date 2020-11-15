using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ConexionSql;

namespace clsNegocios
{
    public class ReportesDeMesaCLS
    {
        public string numero { get; set; }
        public string descripcion { get; set; }

        public string estado { get; set; }
        public string activo { get; set; }


        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string sp_SReporte_mesa = "sp_select_reporte_de_mesa";
        private DataTable mesas;

        public List<ReportesDeMesaCLS> ReporteMesas()
        {
            ClassConexion conexion = new ClassConexion();
            this.mesas = conexion.proceder(sp_SReporte_mesa, param, campos);
            List<ReportesDeMesaCLS> lista = new List<ReportesDeMesaCLS>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.mesas.Rows)
                {
                    lista.Add(new ReportesDeMesaCLS
                    {
                        numero = fila["numero"].ToString(),
                        descripcion = fila["descripcion"].ToString(),
                        estado = fila["estado"].ToString(),
                        activo = fila["activo"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
