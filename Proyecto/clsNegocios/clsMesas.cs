using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ConexionSql;

namespace clsNegocios
{
    public class clsMesas
    {
        public string numero { get; set; }
        public string descripcion { get; set; }

        public string estado { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_buscaMesa = "pa_select_tbl_mesa";
        private DataTable mesas;

        public List<clsMesas> buscaMesas()
        {
            Conexion conexion = new Conexion();
            this.mesas = conexion.proceder(pa_buscaMesa, param, campos);
            List<clsMesas> lista = new List<clsMesas>();
            if (!conexion.error)
            {
                foreach(DataRow fila in this.mesas.Rows)
                {
                    lista.Add(new clsMesas
                    {
                        numero = fila["numero"].ToString(),
                        descripcion = fila["descripcion"].ToString(),
                        estado = fila["estado"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
