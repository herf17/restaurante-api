using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ConexionSql;
namespace clsNegocios
{
    public class clsMantenimientoMesa
    {
        public string numero { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string cargo { get; set; }
        public string activo { get; set; }

        public string mensaje { get; set; }

        private ArrayList parametros = new ArrayList();
        private ArrayList valores = new ArrayList();
        private string sp_insert = "sp_insert_tbl_mesa";
        private string sp_update = "sp_update_tbl_mesa";
        private string sp_select_uno = "sp_select_tbl_mesa_uno";
        private string sp_select_todos = "sp_select_tbl_mesa_todos"; 
        private DataTable listado;
        public clsMantenimientoMesa() { }

        public clsMantenimientoMesa insert_ususario()
        {
            ClassConexion conexion = new ClassConexion();
            parametros.Add("p_numero");
            parametros.Add("p_descripcion");
            parametros.Add("p_estado");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.numero);
            valores.Add(this.descripcion);
            valores.Add(this.estado);
            valores.Add(this.cargo);
            valores.Add(this.activo);
            this.listado = conexion.proceder(sp_insert, parametros, valores);
            if (!conexion.error)
                foreach (DataRow row in this.listado.Rows) { 
                    this.numero = row["numero"].ToString();
                    this.mensaje = "OK";
                }
            else
            {
                this.numero = "0";
                this.mensaje = conexion.MensjError;
            }

            return this;

        }

        public clsMantenimientoMesa update_ususario()
        {
            ClassConexion conexion = new ClassConexion();
            parametros.Add("p_numero");
            parametros.Add("p_descripcion");
            parametros.Add("p_estado");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.numero);
            valores.Add(this.descripcion);
            valores.Add(this.estado);
            valores.Add(this.cargo);
            valores.Add(this.activo);
            this.listado = conexion.proceder(sp_update, parametros, valores);
            if (!!conexion.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    this.numero = row["actualizado"].ToString();
                    this.mensaje = "OK";
                }
            else
            {
                this.numero = "0";
                this.mensaje = conexion.MensjError;
            }

            return this;
        }


        public List<clsMantenimientoMesa> BuscaUsuario()
        {
            ClassConexion conexion = new ClassConexion();
            parametros.Add("p_numero");
            valores.Add(this.numero);
            this.listado = conexion.proceder(sp_select_uno, parametros, valores);
            List<clsMantenimientoMesa> lista = new List<clsMantenimientoMesa>();
            if (!conexion.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsMantenimientoMesa
                    {
                        numero = row["numero"].ToString(),
                        descripcion = row["descripcion"].ToString(),
                        estado = row["estado"].ToString(),
                        cargo = row["cargo"].ToString(),
                        activo = row["activo"].ToString(),                 
                    });
                }
            return lista;
        }

        public List<clsMantenimientoMesa> TodosUsuarios()
        {
            ClassConexion conexion = new ClassConexion();

            this.listado = conexion.proceder(sp_select_todos, parametros, valores);
            List<clsMantenimientoMesa> lista = new List<clsMantenimientoMesa>();
            if (!conexion.error)
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new clsMantenimientoMesa
                    {
                        numero = row["numero"].ToString(),
                        descripcion = row["descripcion"].ToString(),
                        estado = row["estado"].ToString(),
                        cargo = row["cargo"].ToString(),
                        activo = row["activo"].ToString(),
                    });
                }
            return lista;
        }
    }
}
