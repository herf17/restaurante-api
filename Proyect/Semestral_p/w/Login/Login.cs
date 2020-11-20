using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace RestauranteFront
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //paso 1. Crear un objeto para convertirlo a json
            clsUsuario obj_usuario = new clsUsuario();
            obj_usuario.usuario = txtUsuario.Text;
            obj_usuario.contrasenna = txtPassword.Text;

            //Paso 2. Converir objeto a json
            string json = JsonConvert.SerializeObject(obj_usuario);

            //Paso 3. Invocar Servicio Web
            var cliente = new RestClient("http://infodd-001-site1.ftempurl.com/api/usuario/login");
            cliente.Timeout = -1;

            var peticion = new RestRequest(Method.POST);
            peticion.AddHeader("Content-Type", "application/json");
            peticion.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse respuesta = cliente.Execute(peticion);

            //Paso 4. Convertir Json de respuesta en objeto
            List<clsUsuario> lista_obj = JsonConvert.DeserializeObject<List<clsUsuario>>(respuesta.Content);
            if (lista_obj.Count > 0)
            {
                this.Close();
            }
            else
                MessageBox.Show("Erro de usuario o Contraseña");
        }
    }
}
