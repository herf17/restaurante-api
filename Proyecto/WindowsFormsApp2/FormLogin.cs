using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using clsNegocios;


namespace RestauranteFront
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            clsUsuario obj_usuario = new clsUsuario();
            obj_usuario.usuario = txtUsuario.Text;
            obj_usuario.contrasena = txtPassword.Text;

   
            string json = JsonConvert.SerializeObject(obj_usuario);

    
            var cliente = new RestClient("http://infodd-001-site1.ftempurl.com/api/usuario/login");
            cliente.Timeout = -1;

            var peticion = new RestRequest(Method.POST);
            peticion.AddHeader("Content-Type", "application/json");
            peticion.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse respuesta = cliente.Execute(peticion);

           
            List<clsUsuario> lista_obj = JsonConvert.DeserializeObject<List<clsUsuario>>(respuesta.Content);
            if (lista_obj.Count > 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Erro de usuario o Contraseña");
        }


        private void FormLogin_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e)

        {

        }
    }
}
