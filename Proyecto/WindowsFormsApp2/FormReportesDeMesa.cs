using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Parcial1;
using WindowsFormsApp2;

namespace Parcial1 
{
    public partial class FormReportesDeMesa : Form
    {
        private String urlmesa = "ReportesDeMesa/ReporteMesa";
        private String mesas = null;
        List<Model.MesaModel> listaMesas;
        public FormReportesDeMesa()
        {
            InitializeComponent();
          
        }

        private void FormReportesDeMesa_Load(object sender, EventArgs e)
        {
            ApiBase inicioApi = new ApiBase();
            IRestResponse respuesta = inicioApi.execApi(urlmesa, mesas);
            listaMesas = JsonConvert.DeserializeObject<List<Model.MesaModel>>(respuesta.Content);
            
            for (int n = 0; n < listaMesas.Count; n++)
            {
         
                String[] arr = { listaMesas[n].numero,
                                        listaMesas[n].descripcion, 
                                        listaMesas[n].estado,
                                        listaMesas[n].activo };
                dgvReportesDeMesa.Rows.Add(arr);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
