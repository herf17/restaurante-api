using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using CapaDeConexionCLS;

namespace ProyectoSemestral
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConexionClS con = new ConexionClS();


            dataGridViewDetalle.Rows.Add("Soda", 2, 2.32, 10.23);
            dataGridViewDetalle.Rows.Add("Pizza", 2, 14.00, 28.00);
            dataGridViewDetalle.Rows.Add("Pollo", 10, 2.0, 20.00);
            dataGridViewDetalle.Rows.Add("Tamal", 5, 1.75, 8.50);
            dataGridViewDetalle.Rows.Add("Papas fritas", 5, 1.00, 5.00);
            dataGridViewDetalle.Rows.Add("Papas", 5, 1.00, 5.00);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //ConexionClS con = new ConexionClS();
            /**
             foreach (row r  in dataGridViewDetalle.SelectedRows){
                 dataGridViewDetalle.Rows.Remove(row);
             }
             **/

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void subReporteMesa_Click(object sender, EventArgs e)
        {

            // frmRM objeto que representa   FormReportesDeMesa en siglas

            FormReportesDeMesa frmRM = new FormReportesDeMesa();
            frmRM.Show();
        }

        private void subReporteProductos_Click(object sender, EventArgs e)
        {
            // frmRP objeto que representa  FormReportesDeProductos en siglas

            FormReportesDeProductos frmRP = new FormReportesDeProductos();
            frmRP.Show();
        }

        private void subReporteProductoMásVendido_Click(object sender, EventArgs e)
        {
            // frmPMV objeto que representa  FormReportesDeProductosMasVendidos en siglas

            FormReportesDeProductosMasVendidos frmPMV = new FormReportesDeProductosMasVendidos();
            frmPMV.Show();
        }

        private void subReporteVentasTotales_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void subReporteVentasTotales_Click(object sender, EventArgs e)
        {
            // frmRVT objeto que representa  FormReportesDeVentasTotales en siglas

            FormReportesDeVentasTotales frmRVT = new FormReportesDeVentasTotales();
            frmRVT.Show();
        }

        private void subReporteOrdenes_Click(object sender, EventArgs e)
        {
            // frmRDO objeto que representa   FormReportesDeOrdenes en siglas

            FormReportesDeOrdenes frmRDO = new FormReportesDeOrdenes();
            frmRDO.Show();
        }

        private void dataGridViewDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
