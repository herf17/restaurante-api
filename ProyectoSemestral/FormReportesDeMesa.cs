using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSemestral
{
    public partial class FormReportesDeMesa : Form
    {
        public FormReportesDeMesa()
        {
            InitializeComponent();
        }

        private void FormReportesDeMesa_Load(object sender, EventArgs e)
        {
            dgvReportesDeMesa.Rows.Add(1, "Descripcion",  "L", 1);
            dgvReportesDeMesa.Rows.Add(2, "Descripcion",  "L", 1);
            dgvReportesDeMesa.Rows.Add(3, "Descripcion", "L", 1);
            dgvReportesDeMesa.Rows.Add(4, "Descripcion",  "L", 1);
            dgvReportesDeMesa.Rows.Add(5, "Descripcion",  "L", 1);
        }
    }
}
