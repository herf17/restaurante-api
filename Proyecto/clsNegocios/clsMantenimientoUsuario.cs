//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using ConexionSql;

//namespace clsNegocios
//{
//    public class clsMantenimientoUsuario
//    {
//        public string id_usuario { get; set; }
//        public string usuario { get; set; }
//        public string contrasena { get; set; }
//        public string nombre { get; set; }
//        public string cargo { get; set; }
//        public string activo { get; set; }
//        public string fecha_adicion { get; set; }
//        public string fecha_modificacion { get; set; }

//        public string mensaje { get; set; }

//        private ArrayList parametros = new ArrayList();
//        private ArrayList valores = new ArrayList();
//        private string sp_insert = "sp_insert_tbl_usuario";
//        private string sp_update = "sp_update_tbl_usuario";
//        private string sp_select_uno = "sp_select_tbl_usuario_uno";
//        private string sp_select_todos = "sp_select_tbl_usuario_todos"; 
//        private DataTable listado;
//        public clsMantenimientoUsuario() { }

//        public clsMantenimientoUsuario insert_ususario()
//        {
//            ClassConexion conexion = new ClassConexion();
//            parametros.Add("p_usuario");
//            parametros.Add("p_contrasena");
//            parametros.Add("p_nombre");
//            parametros.Add("p_cargo");
//            parametros.Add("p_activo");

//            valores.Add(this.usuario);
//            valores.Add(this.contrasena);
//            valores.Add(this.nombre);
//            valores.Add(this.cargo);
//            valores.Add(this.activo);
//            this.listado = conexion.proceder(sp_insert, parametros, valores);
//            if (!conexion.error)
//                foreach (DataRow row in this.listado.Rows) { 
//                    this.id_usuario = row["id_usuario"].ToString();
//                    this.mensaje = "OK";
//                }
//            else
//            {
//                this.id_usuario = "0";
//                this.mensaje = conexion.MensjError;
//            }

//            return this;

//        }

//        public clsMantenimientoUsuario update_ususario()
//        {
//            ClassConexion conexion = new ClassConexion();
//            parametros.Add("p_id_usuario");
//            parametros.Add("p_usuario");
//            parametros.Add("p_contrasena");
//            parametros.Add("p_nombre");
//            parametros.Add("p_cargo");
//            parametros.Add("p_activo");

//            valores.Add(this.id_usuario);
//            valores.Add(this.usuario);
//            valores.Add(this.contrasena);
//            valores.Add(this.nombre);
//            valores.Add(this.cargo);
//            valores.Add(this.activo);
//            this.listado = conexion.proceder(sp_update, parametros, valores);
//            if (!conexion.error)
//                foreach (DataRow row in this.listado.Rows)
//                {
//                    this.id_usuario = row["actualizado"].ToString();
//                    this.mensaje = "OK";
//                }
//            else
//            {
//                this.id_usuario = "0";
//                this.mensaje = conexion.MensjError;
//            }

//            return this;
//        }


//        public List<clsUsuario> BuscaUsuario()
//        {
//            ClassConexion con = new ClassConexion();
//            parametros.Add("p_id_usuario");
//            valores.Add(this.id_usuario);
//            this.listado = con.proceder(sp_select_uno, parametros, valores);
//            List<clsMantenimientoUsuario> lista = new List<clsMantenimientoUsuario>();
//            if (!con.error)
//                foreach (DataRow row in this.listado.Rows)
//                {
//                    lista.Add(new clsMantenimientoUsuario
//                    {
//                        id_usuario = row["id_usuario"].ToString(),
//                        usuario = row["usuario"].ToString(),
//                        contrasena = row["contrasena"].ToString(),
//                        nombre = row["nombre"].ToString(),
//                        cargo = row["cargo"].ToString(),
//                        activo = row["activo"].ToString(),
//                        fecha_adicion = row["fecha_adicion"].ToString(),
//                        fecha_modificacion = row["fecha_modificacion"].ToString()
//                    });
//                }
//            return lista;
//        }

//        public List<clsMantenimientoUsuario> TodosUsuarios()
//        {
//            ClassConexion conexion = new ClassConexion();

//            this.listado = conexion.proceder(sp_select_todos, parametros, valores);
//            List<clsMantenimientoUsuario> lista = new List<clsMantenimientoUsuario>();
//            if (!conexion.error)
//                foreach (DataRow row in this.listado.Rows)
//                {
//                    lista.Add(new clsMantenimientoUsuario
//                    {
//                        id_usuario = row["id_usuario"].ToString(),
//                        usuario = row["usuario"].ToString(),
//                        contrasena = row["contrasena"].ToString(),
//                        nombre = row["contrasenna"].ToString(),
//                        cargo = row["cargo"].ToString(),
//                        activo = row["activo"].ToString(),
//                        fecha_adicion = row["fecha_adicion"].ToString(),
//                        fecha_modificacion = row["fecha_modificacion"].ToString()
//                    });
//                }
//            return lista;
//        }
//    }
//}
