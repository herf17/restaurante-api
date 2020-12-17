using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using clsNegocios;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace RestauranteFront
{
    public partial class FormVerUsuario : Form
    {
        public FormVerUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();

    
            var cliente = new RestClient("");
            cliente.Timeout = -1;

            var peticion = new RestRequest(Method.POST);
            peticion.AddHeader("Content-Type", "application/json");
            IRestResponse respuesta = cliente.Execute(peticion);


            List<clsUsuario> lista_obj = JsonConvert.DeserializeObject<List<clsUsuario>>(respuesta.Content);
            for(int n = 0; n < lista_obj.Count; n++)
            {
                String[] arr = { lista_obj[n].id_usuario, lista_obj[n].usuario, lista_obj[n].contrasena, lista_obj[n].nombre, lista_obj[n].cargo, lista_obj[n].activo };
                dataGridView1.Rows.Add(arr);
                
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormRegistrarUsuario frm = new FormRegistrarUsuario();
            frm.ShowDialog();
        }
    }
}
