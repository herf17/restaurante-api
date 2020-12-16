using System;
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

namespace Semestre_P1
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
<<<<<<< HEAD
            //Formulario ecp = new Formulario();
            //ecp.ShowDialog();
        }

        private void FormMenuAdministracion_Load(object sender, EventArgs e)
        {

=======
            FormRegistrarUsuario ecp = new FormRegistrarUsuario();
            ecp.ShowDialog();
>>>>>>> 6114df3a555751c45d7b76a7d29acb9447860381
        }
    }
}
