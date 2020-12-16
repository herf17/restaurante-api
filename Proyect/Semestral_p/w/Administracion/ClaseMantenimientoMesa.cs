using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace Proyecto.Administracion
{
    class ClaseMantenimientoMesa
    {
        public string numero { get; set; }
        public string descripcion { get; set; }

        public string estado { get; set; }
        public List<ProductosEnOrden> pror { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_buscaMesa = "pa_select_tbl_mesa";
        private string pa_producto_mesa = "pa_productos_enorden";
        private DataTable mesas;

        public List<clsMesas> buscaMesas()
        {
            Conexion conexion = new Conexion();
            this.mesas = conexion.proceder(pa_buscaMesa, param, campos);
            List<clsMesas> lista = new List<clsMesas>();
            if (!conexion.error)
            {
                foreach (DataRow fila in this.mesas.Rows)
                {
                    List<ProductosEnOrden> y = new List<ProductosEnOrden>();
                    if (fila["estado"].ToString() == "O")
                    {
                        ArrayList p = new ArrayList();
                        ArrayList c = new ArrayList();
                        p.Add("codmesa");
                        c.Add(fila["numero"].ToString());
                        Conexion con = new Conexion();
                        DataTable objeto = con.proceder(pa_producto_mesa, p, c);
                        if (!con.error)
                        {
                            foreach (DataRow fi in objeto.Rows)
                            {
                                y.Add(new ProductosEnOrden
                                {
                                    producto = fi["descripcion"].ToString(),
                                    cantidad = fi["cantidad"].ToString()
                                });
                            }
                        }
                    }
                    if (fila["estado"].ToString() == "O")
                        lista.Add(new clsMesas
                        {
                            numero = fila["numero"].ToString(),
                            descripcion = fila["descripcion"].ToString(),
                            estado = fila["estado"].ToString(),
                            pror = y
                        });
                    else
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
