using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Parcial1;

namespace WindowsFormsApp2
{
    public partial class escojerMesa : Form
    {
        private String urlcont = "solicitarordenes/mesas";
        private String mesascoman = null;
        List<Model.MesasModel> listaMesas;
        public escojerMesa()
        {
            InitializeComponent();
            iniciaMesa();
        }

        private void iniciaMesa()
        {
            ApiBase inicioApi = new ApiBase();
            IRestResponse respuesta = inicioApi.execApi(urlcont, mesascoman);
            listaMesas = JsonConvert.DeserializeObject<List<Model.MesasModel>>(respuesta.Content);
            if(listaMesas.Count > 0)
            {
                for(int i = 0; i < listaMesas.Count;i++)
                {
                    Button botonPro = new Button();
                    botonPro.Name = "btmesas" + i;
                    botonPro.Text = "" + listaMesas[i].numero;
                    botonPro.Height = 100;
                    botonPro.Width = 100;
                    botonPro.ForeColor = Color.White;
                    if (String.Equals(listaMesas[i].estado, "O"))
                    {
                        botonPro.BackColor = Color.Red;

                    }
                    else
                        botonPro.BackColor = Color.Green;
                    flpMesas.Controls.Add(botonPro);
                    botonPro.Click += new EventHandler(button_Click);
                }
            }
        }
        protected void button_Click(Object sender, EventArgs e)
        {
            Button button = sender as Button;
            String str = button.Name.Substring(button.Name.Length-1);
            Model.MesasModel mesasModel = listaMesas[int.Parse(str)];
            if(String.Equals(mesasModel.estado, "O"))
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Producto",typeof(string));
                dataTable.Columns.Add("Cantidad", typeof(string));
                for (int h = 0; h < mesasModel.pror.Count; h++)
                {
                    dataTable.Rows.Add(mesasModel.pror[h].producto,mesasModel.pror[h].cantidad);
                }
                EstadoMesaO estadoMesao = new EstadoMesaO(dataTable,mesasModel.descripcion);
                estadoMesao.OcupadO += new EstadoMesaO.OrdenOcupado(this.Ordentermina);
                estadoMesao.Show();
            }else if(String.Equals(mesasModel.estado, "L"))
            {
                Form1 form = new Form1(mesasModel.numero);
                form.OnAviso += new Form1.OrdenNueva(this.Ordentermina);
                form.Show();
            }
        }
        private void Ordentermina(String idorden)
        {
            MessageBox.Show("Orden agregada con exito. Factura: "+idorden);
            this.Controls.Clear();
            this.InitializeComponent();
            this.iniciaMesa();
        }
        private void actualizarOcupado(String ocu)
        {

        }
        private void flpMesas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
