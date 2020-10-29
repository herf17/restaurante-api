using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class escojerMesa : Form
    {
        public escojerMesa()
        {
            InitializeComponent();
            iniciaMesa();
        }

        private void iniciaMesa()
        {
            Random ran = new Random();

            for (int m = 0; m < 30; m++)
            {
                int al = ran.Next(1, 125);
                
                Button botonPro = new Button();
                botonPro.Name = "btmesas" + m.ToString();
                botonPro.Text = "Mesa #" + m.ToString();
                botonPro.Height = 100;
                botonPro.Width = 100;
                botonPro.ForeColor = Color.White;
                if (al % 2 == 0)
                    botonPro.BackColor = Color.Green;
                else
                    botonPro.BackColor = Color.Red;
                flpMesas.Controls.Add(botonPro);

            }
        }
        private void flpMesas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
