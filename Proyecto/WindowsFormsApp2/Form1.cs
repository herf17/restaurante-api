using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargaboto();
        }
        private void cargaboto()
        {
            //Carga categoria 1 entrada
            for (int n = 0; n < 10; n++)
            {
                Button botonCat = new Button();
                botonCat.Name = "Entrada" + n.ToString();
                botonCat.Text = "Entreda #" + n.ToString();
                botonCat.Width = 90;
                botonCat.Height = 80;
                botonCat.Click += new EventHandler(clickMesa);
                flpCentra.Controls.Add(botonCat);
            }
            for (int i = 0; i < 10; i++)
            {
                Button botonCat = new Button();
                botonCat.Name = "btncat" + i.ToString();
                botonCat.Text = "categoria" + i.ToString();
                botonCat.Width = 90;
                botonCat.Height = 80;
                flpCplatosfue.Controls.Add(botonCat);
            }
            for (int j = 0; j < 30; j++)
            {
                Button botonPro = new Button();
                botonPro.Name = "btnprod" + j.ToString();
                botonPro.Text = "producto #" + j.ToString();
                botonPro.Height = 100;
                botonPro.Width = 100;
                botonPro.Click += new EventHandler(clickProducto);
                flpProductos.Controls.Add(botonPro);

            }
            
            for (int a = 0; a < 10; a++)
            {
                Button botonCat = new Button();
                botonCat.Name = "Entrada" + a.ToString();
                botonCat.Text = "Entrada #" + a.ToString();
                botonCat.Width = 90;
                botonCat.Height = 80;
                flpCbebidas.Controls.Add(botonCat);
            }
            for (int b = 0; b < 10; b++)
            {
                Button botonCat = new Button();
                botonCat.Name = "Entrada" + b.ToString();
                botonCat.Text = "Postre #" + b.ToString();
                botonCat.Width = 90;
                botonCat.Height = 80;
                flpCpostres.Controls.Add(botonCat);
            }
        }

        private void clickProducto(object sender, EventArgs e)
        {
            escojerCantidadProducto ecp = new escojerCantidadProducto();
            ecp.ShowDialog();
        }
        private void clickMesa(object sender, EventArgs e)
        {
            escojerMesa em = new escojerMesa();
            em.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flpCentra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
