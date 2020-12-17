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
    public partial class FormReportesDeVentasTotales : Form
    {
        private String urlventas = "ReportesDeVentasTotales/ReporteProductos";
        private String ventas = null;
        List<Model.ReportesDeVentasTotalesModel> listaventas;

        public FormReportesDeVentasTotales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReportesDeVentasTotales_Load(object sender, EventArgs e)
        {
            ApiBase inicioApi = new ApiBase();
            IRestResponse respuesta = inicioApi.execApi(urlventas, ventas);
            listaventas = JsonConvert.DeserializeObject<List<Model.ReportesDeVentasTotalesModel>>(respuesta.Content);

            for (int n = 0; n < listaventas.Count; n++)
            {
                Console.WriteLine("Ventas ejecuntandoce");
                //String[] arr = { listaventas[n].id_producto,
                //                                listaventas[n].descripcion,
                //                                listaventas[n].precio,
                //                                listaventas[n].cantidad,
                //                                listaventas[n].id_categoria,
                //                                listaventas[n].activo };
                //dgvReportesDeVentasTotales.Rows.Add(arr);

            }


          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
