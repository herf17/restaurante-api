using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSemestral
{
    public partial class FormReportesDeOrdenes : Form
    {
        public FormReportesDeOrdenes()
        {
            InitializeComponent();
        }

        private void FormReportesDeOrdenes_Load(object sender, EventArgs e)
        {
            dgvReportesDeOrdenes.Rows.Add(1, "Soda", 2, 2.32, 10.23);
            dgvReportesDeOrdenes.Rows.Add(2, "Pizza", 2, 14.00, 28.00);
            dgvReportesDeOrdenes.Rows.Add(3, "Pollo", 10, 2.0, 20.00);
            dgvReportesDeOrdenes.Rows.Add(4, "Tamal", 5, 1.75, 8.50);
            dgvReportesDeOrdenes.Rows.Add(5, "Papas fritas", 5, 1.00, 5.00);
        }
    }
}
