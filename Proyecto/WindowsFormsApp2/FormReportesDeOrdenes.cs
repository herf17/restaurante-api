using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Parcial1
{
    public partial class FormReportesDeOrdenes : Form
    {
        private String urlmesa = "ReportesDeOrdens/ReporteOrdenes";
        private String mesas = null;
        List<Model.ReporteOrdenesModel> listaOrdenes;
        public FormReportesDeOrdenes()
        {
            InitializeComponent();
        }

        private void FormReportesDeOrdenes_Load(object sender, EventArgs e)
        {
            ApiBase inicioApi = new ApiBase();
            IRestResponse respuesta = inicioApi.execApi(urlmesa, mesas);
            listaOrdenes = JsonConvert.DeserializeObject<List<Model.ReporteOrdenesModel>>(respuesta.Content);

            for (int n = 0; n < listaOrdenes.Count; n++)
            {
                String[] arr = { listaOrdenes[n].id_orden,
                                                listaOrdenes[n].fecha_hora,
                                                listaOrdenes[n].total,
                                                listaOrdenes[n].nombre,
                                                listaOrdenes[n].numero,
                                                listaOrdenes[n].estado };
                dgvReportesDeOrdenes.Rows.Add(arr);

                    }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
