using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semestre_P1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Administracion ecp = new Administracion();
            // ecp.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ecp = new Form();
            ecp.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
