using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;

using ConexionSql;

namespace clsNegocios
{
    public class UsuarioCLS
    {
        public string id_usuario { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string cargo { get; set; }
        public string activo { get; set; }
        public string fecha_adicion { get; set; }
        public string fecha_modificacion { get; set; }

        public string mensaje { get; set; }

        private ArrayList parametros = new ArrayList();
        private ArrayList valores = new ArrayList();
        private string sp_insert = "sp_insert_tbl_usuario";
        private string sp_update = "sp_update_tbl_usuario";
        private string sp_select_uno = "sp_select_tbl_usuario_uno";
        private string sp_select_todos = "sp_select_tbl_usuario_todos";


        private DataTable listado;

        public UsuarioCLS() { }

        public UsuarioCLS insertUsuario()
        {
            ClassConexion con = new ClassConexion();

            parametros.Add("p_usuario");
            parametros.Add("p_nombre");
            parametros.Add("p_contrasena");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.usuario);
            valores.Add(this.nombre);
            valores.Add(this.contrasena);
            valores.Add(this.cargo);
            valores.Add(this.activo);

            this.listado = con.proceder(sp_insert, parametros, valores);

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_usuario = row["id_usuario"].ToString();
                    this.mensaje = "ok";
                }
            }
            else
            {
                this.id_usuario = "0";
                this.mensaje = con.MensjError;
            }

            return this;
        }

        public UsuarioCLS updateUsuario()
        {
            ClassConexion con = new ClassConexion();
            parametros.Add("p_id_usuario");
            parametros.Add("p_usuario");
            parametros.Add("p_nombre");
            parametros.Add("p_contrasena");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.id_usuario);
            valores.Add(this.usuario);
            valores.Add(this.nombre);
            valores.Add(this.contrasena);
            valores.Add(this.cargo);
            valores.Add(this.activo);

            this.listado = con.proceder(sp_update, parametros, valores);

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    this.id_usuario = row["actualizado"].ToString();
                    this.mensaje = "ok";
                }
            }
            else
            {
                this.id_usuario = "0";
                this.mensaje = con.MensjError;
            }
            return this;
        }

        public List<UsuarioCLS> BuscaUsuario()
        {
            ClassConexion con = new ClassConexion();
            parametros.Add("p_id_usuario");
            valores.Add(this.id_usuario);

            this.listado = con.proceder(sp_select_uno, parametros, valores);

            List<UsuarioCLS> lista = new List<UsuarioCLS>();

            if (!con.error)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new UsuarioCLS
                    {
                        id_usuario = row["id_usuario"].ToString(),
                        usuario = row["usuario"].ToString(),
                        contrasena = row["contrasena"].ToString(),
                        nombre = row["nombre"].ToString(),
                        cargo = row["cargo"].ToString(),
                        activo = row["activo"].ToString(),
                        fecha_adicion = row["fecha_adicion"].ToString(),
                        fecha_modificacion = row["fecha_modificacion"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}