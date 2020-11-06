using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using CapaDeConexionCLS;

namespace CapaDeNegocioCLS
{
    public class UsuarioCLS
    {
        public string id_usuario { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string contrasenna { get; set; }
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
            ConexionClS con = new ConexionClS();

            parametros.Add("p_usuario");
            parametros.Add("p_nombre");
            parametros.Add("p_contrasenna");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.usuario);
            valores.Add(this.nombre);
            valores.Add(this.contrasenna);
            valores.Add(this.cargo);
            valores.Add(this.activo);

            this.listado = con.Ejecutar(sp_insert, parametros, valores);

            if (!con.isError)
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
                this.mensaje = con.mensajeError;
            }

            return this;
        }

        public UsuarioCLS updateUsuario()
        {
            ConexionClS con = new ConexionClS();
            parametros.Add("p_id_usuario");
            parametros.Add("p_usuario");
            parametros.Add("p_nombre");
            parametros.Add("p_contrasenna");
            parametros.Add("p_cargo");
            parametros.Add("p_activo");

            valores.Add(this.id_usuario);
            valores.Add(this.usuario);
            valores.Add(this.nombre);
            valores.Add(this.contrasenna);
            valores.Add(this.cargo);
            valores.Add(this.activo);

            this.listado = con.Ejecutar(sp_update, parametros, valores);

            if (!con.isError)
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
                this.mensaje = con.mensajeError;
            }
            return this;
        }

        public List<UsuarioCLS> BuscaUsuario()
        {
            ConexionClS con = new ConexionClS();
            parametros.Add("p_id_usuario");
            valores.Add(this.id_usuario);

            this.listado = con.Ejecutar("sp_select_uno", parametros, valores);

            List<UsuarioCLS> lista = new List<UsuarioCLS>();

            if (!con.isError)
            {
                foreach (DataRow row in this.listado.Rows)
                {
                    lista.Add(new UsuarioCLS
                    {
                        id_usuario = row["id_usuario"].ToString(),
                        usuario = row["usuario"].ToString(),
                        contrasenna = row["contrasenna"].ToString(),
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