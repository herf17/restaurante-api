using System;
using Parcial1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using clsNegocios;

namespace Parcial1
{
    public partial class FormMenuAdministracion : Form
    {
        public FormMenuAdministracion()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            FormRegistrarUsuario ecp = new FormRegistrarUsuario();
            ecp.ShowDialog();
        }

        private void FormMenuAdministracion_Load(object sender, EventArgs e)
        {


            FormRegistrarUsuario ecp = new FormRegistrarUsuario();
            ecp.ShowDialog();

        }
    }
}
