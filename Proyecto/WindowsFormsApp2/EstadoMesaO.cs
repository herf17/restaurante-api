using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace Parcial1
{
    public partial class EstadoMesaO : Form
    {   
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
    }
}
