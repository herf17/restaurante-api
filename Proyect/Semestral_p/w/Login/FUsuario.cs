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
    public partial class FUsuario : Form
    {
        public FUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //paso 1. Crear un objeto para convertirlo a json
            clsUsuario obj_usuario = new clsUsuario();
            obj_usuario.usuario = txtUsuario.Text;
            obj_usuario.contrasenna = txtContrasenna.Text;
            obj_usuario.nombre = txtNombre.Text;
            obj_usuario.cargo = txtCargo.Text;
            obj_usuario.activo = txtActivo.Text;

            //Paso 2. Converir objeto a json
            string json = JsonConvert.SerializeObject(obj_usuario);

            //Paso 3. Invocar Servicio Web
            var cliente = new RestClient("http://infodd-001-site1.ftempurl.com/api/usuario/insertar");
            cliente.Timeout = -1;

            var peticion = new RestRequest(Method.POST);
            peticion.AddHeader("Content-Type", "application/json");
            peticion.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse respuesta = cliente.Execute(peticion);

            //Paso 4. Convertir Json de respuesta en objeto
            obj_usuario = JsonConvert.DeserializeObject<clsUsuario>(respuesta.Content);
            if (obj_usuario.mensaje == "OK")
                MessageBox.Show("Se ha creado el usuario con ID " + obj_usuario.id_usuario);
            else
                MessageBox.Show("No se creó el usuario, intente nuevamente.");
        }
    }
}
