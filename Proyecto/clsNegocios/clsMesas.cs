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
        public List<ProductosEnOrden> pror { get; set; }

        private ArrayList param = new ArrayList();
        private ArrayList campos = new ArrayList();
        private string pa_buscaMesa = "pa_select_tbl_mesa";
        private string pa_producto_mesa = "pa_productos_enorden";
        private string pa_orden = "pa_select_orden_mesaocupada";
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
                    List<ProductosEnOrden> y = new List<ProductosEnOrden>();
                    if (fila["estado"].ToString()=="O")
                    {
                        ArrayList p = new ArrayList();
                        ArrayList c = new ArrayList();
                        p.Add("codmesa");
                        c.Add(fila["numero"].ToString());
                        Conexion con = new Conexion();
                        DataTable objeto = con.proceder(pa_producto_mesa,p,c);
                        if (!con.error)
                        {
                            foreach(DataRow fi in objeto.Rows)
                            {
                                y.Add(new ProductosEnOrden 
                                { 
                                    producto = fi["descripcion"].ToString(), 
                                    cantidad = fi["cantidad"].ToString() 
                                });
                            }
                        }
                    }
                    if(fila["estado"].ToString() == "O")
                    {
                        ArrayList pp = new ArrayList();
                        ArrayList cc = new ArrayList();
                        pp.Add("codmesa");
                        cc.Add(fila["numero"].ToString());
                        Conexion connn = new Conexion();
                        DataTable objeto = connn.proceder(pa_orden, pp, cc);
                        string idorden ="";
                        foreach (DataRow fia in objeto.Rows)
                        {
                            idorden = fia["id_orden"].ToString();
                        }
                        lista.Add(new clsMesas
                        {
                            numero = fila["numero"].ToString(),
                            descripcion = idorden,
                            estado = fila["estado"].ToString(),
                            pror = y
                        });
                    }
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
