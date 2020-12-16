using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2;
using Newtonsoft.Json;
using RestSharp;

namespace Parcial1
{
    public partial class EstadoMesaO : Form
    {
        public delegate void OrdenOcupado(string mnj);
        public event OrdenOcupado OcupadO;

        private String urlanular = "solicitarordenes/anular";
        private String urlculminar = "solicitarordenes/ordenterminar";
        private string idorden;


        private DataTable dataTable;
        public EstadoMesaO(DataTable dt,string id)
        {
            InitializeComponent();
            gridview.DataSource = dt;
            this.dataTable = dt;
            this.idorden = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            ApiBase api = new ApiBase();
            OrdenModel orden = new OrdenModel();
            orden.id_orden = idorden;
            IRestResponse res = api.execApi(urlanular, JsonConvert.SerializeObject(orden));
            string h = JsonConvert.DeserializeObject<String>(res.Content);
            if (!string.IsNullOrEmpty(h))
            {
                this.OcupadO(h);
                this.Close();
            }else
                MessageBox.Show("Error");

        }

        private void btnculm_Click(object sender, EventArgs e)
        {
            ApiBase api = new ApiBase();
            OrdenModel orden = new OrdenModel();
            orden.id_orden = idorden;
            IRestResponse res = api.execApi(urlculminar, JsonConvert.SerializeObject(orden));
            string h = JsonConvert.DeserializeObject<String>(res.Content);
            if (!string.IsNullOrEmpty(h))
            {
                this.OcupadO(h);
                this.Close();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
