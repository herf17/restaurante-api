using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSemestral
{
    public partial class FormReportesDeProductos : Form
    {
        public FormReportesDeProductos()
        {
            InitializeComponent();
        }

        private void FormReportesDeProductos_Load(object sender, EventArgs e)
        {
            dgvReportesDeProductos.Rows.Add(1, "Soda Coca cola", 2,  2.32,  "Refrescos",  1);
            dgvReportesDeProductos.Rows.Add(2, "Pizza Peperoni", 2,  14.00, "Pizza",      1);
            dgvReportesDeProductos.Rows.Add(3, "Alitas",         10, 2.0,   "Pollos",     1);
            dgvReportesDeProductos.Rows.Add(4, "Sancocho",       5,  1.75,  "Sopa",       1);
            dgvReportesDeProductos.Rows.Add(5, "Papas fritas",   5,  1.00,  "Frituras",   1);
        }
    }
}
