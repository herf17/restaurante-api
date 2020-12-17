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

namespace Parcial1 { 
    public partial class FormReportesDeProductos : Form
    {
        private String urlproductos = "ReportesDeProductos/ReporteProductos";
        private String productos = null;
        List<Model.ReportesProductosModel> listaProductos;

        public FormReportesDeProductos()
        {
            InitializeComponent();
        }

        private void FormReportesDeProductos_Load(object sender, EventArgs e)
        {


            ApiBase inicioApi = new ApiBase();
            IRestResponse respuesta = inicioApi.execApi(urlproductos, productos);
            listaProductos = JsonConvert.DeserializeObject<List<Model.ReportesProductosModel>>(respuesta.Content);
            
                    for (int n = 0; n<listaProductos.Count; n++)
                    {
         
                        String[] arr = { listaProductos[n].id_producto,
                                                listaProductos[n].descripcion,
                                                listaProductos[n].precio,
                                                listaProductos[n].cantidad,
                                                listaProductos[n].id_categoria,
                                                listaProductos[n].activo };
                        dgvReportesDeProductos.Rows.Add(arr);

                    }
        }
    }
}
