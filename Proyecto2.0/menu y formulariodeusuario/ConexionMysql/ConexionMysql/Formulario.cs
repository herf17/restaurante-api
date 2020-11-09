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

namespace ConexionMysql


{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
    
    private void Formulario_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=;database=restaurante");
        using (con)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("sp_insert_tbl_usuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("p_contrasenna", txtContrasenna.Text);
            cmd.Parameters.AddWithValue("p_nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("p_cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("p_activo", "1");
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            foreach (DataRow fila in dt.Rows)
                MessageBox.Show("El id insertado es " + fila["id_usuario"]);
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=;database=restaurante");
        using (con)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("sp_select_tbl_usuario_uno", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_id_usuario", txtIdUsuario.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            if (dt.Rows.Count > 0)
                foreach (DataRow fila in dt.Rows)
                {
                    txtUsuario.Text = fila["usuario"].ToString();
                    txtContrasenna.Text = fila["contrasenna"].ToString();
                    txtNombre.Text = fila["nombre"].ToString();
                    txtCargo.Text = fila["cargo"].ToString();
                }
            else
                MessageBox.Show("no se encuentra el registro");
        }
    }
}
}
