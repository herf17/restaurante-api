using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using clsNegocios;
using Newtonsoft.Json;


namespace RestauranteFront
{
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            clsUsuario obj_usuario = new clsUsuario();
            obj_usuario.usuario = txtUsuario.Text;
            obj_usuario.contrasena = txtContrasenna.Text;
            obj_usuario.nombre = txtNombre.Text;
            obj_usuario.cargo = txtCargo.Text;
            obj_usuario.activo = txtActivo.Text;

    
            string json = JsonConvert.SerializeObject(obj_usuario);

          
            var cliente = new RestClient("");
            cliente.Timeout = -1;

            var peticion = new RestRequest(Method.POST);
            peticion.AddHeader("Content-Type", "application/json");
            peticion.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse respuesta = cliente.Execute(peticion);

         
            obj_usuario = JsonConvert.DeserializeObject<clsUsuario>(respuesta.Content);
            if (obj_usuario.mensaje == "OK")
                MessageBox.Show("Se ha creado el usuario con ID " + obj_usuario.id_usuario);
            else
                MessageBox.Show("No se creó el usuario, intente nuevamente.");
        }

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
