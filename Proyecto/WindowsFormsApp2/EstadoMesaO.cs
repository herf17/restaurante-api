using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2;

namespace Parcial1
{
    public partial class EstadoMesaO : Form
    {
        public delegate void OrdenOcupado(string mnj);
        public event OrdenOcupado OcupadO;

        private String urlanular = "solicitarordenes/anular";
        private String urlculminar = "solicitarordenes/ordenterminar";


        private DataTable dataTable;
        public EstadoMesaO(DataTable dt)
        {
            InitializeComponent();
            gridview.DataSource = dt;
            this.dataTable = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            ApiBase api = new ApiBase();
            OrdenModel orden = new OrdenModel();
            orden.id_orden = 
        }

        private void btnculm_Click(object sender, EventArgs e)
        {

        }
    }
}
