using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSemestral
{
    public partial class FormReportesDeVentasTotales : Form
    {
        public FormReportesDeVentasTotales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReportesDeVentasTotales_Load(object sender, EventArgs e)
        {
            dgvReportesDeVentasTotales.Rows.Add(1, 2.32,  "12-2-2020");
            dgvReportesDeVentasTotales.Rows.Add(2, 14.00, "12-2-2020");
            dgvReportesDeVentasTotales.Rows.Add(3, 20.0,  "12-2-2020");
            dgvReportesDeVentasTotales.Rows.Add(4, 112.75,"12-2-2020");
            dgvReportesDeVentasTotales.Rows.Add(5, 70.00, "12-2-2020");
        }
    }
}
