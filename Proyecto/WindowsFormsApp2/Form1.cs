using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private String urlcatgcont = "solicitarordenes/categorias";
        private String urlprodgcont = "solicitarordenes/productoscatg";
        private String coman = null;
        List<Model.CategModel> listaCatg;
        List<Model.ProdEnCatgModel> prodCatg;
        public Form1()
        {
            InitializeComponent();
            cargaboto();
        }
        private void cargaboto()
        {
            //Carga categoria 1 entrada
            ApiBase apbase = new ApiBase();
            IRestResponse respuesta = apbase.execApi(urlcatgcont, coman);
            listaCatg = JsonConvert.DeserializeObject<List<Model.CategModel>>(respuesta.Content);

            for (int i = 0; i < listaCatg.Count; i++)
            {
                Button botonCat = new Button();
                botonCat.Name = "btncat" + i;
                botonCat.Text = listaCatg[i].nombre;
                botonCat.Width = 90;
                botonCat.Height = 80;
                flpCplatosfue.Controls.Add(botonCat);
                botonCat.Click += new EventHandler(clickCatg);
            }
            
        }

        private void clickProducto(object sender, EventArgs e)
        {
            escojerCantidadProducto ecp = new escojerCantidadProducto();
            ecp.ShowDialog();
        }
        private void clickCatg(object sender, EventArgs e)
        {
            if (flpProductos.Controls.Count>0)
            {
                flpProductos.Controls.Clear();
            }
            Button button = sender as Button;
            String str = button.Name.Substring(button.Name.Length - 1);
            ApiBase apbasep = new ApiBase();
            Model.ProdEnCatgModel obj = new Model.ProdEnCatgModel();
            obj.id_categoria = listaCatg[int.Parse(str)].id_categoria;
            IRestResponse respuesta2 = apbasep.execApi(urlprodgcont, JsonConvert.SerializeObject(obj));
            prodCatg = JsonConvert.DeserializeObject<List<Model.ProdEnCatgModel>>(respuesta2.Content);
            for (int j = 0; j < prodCatg.Count; j++)
            {
                Button botonPro = new Button();
                botonPro.Name = "btnprod" + j;
                botonPro.Text = prodCatg[j].descripcion;
                botonPro.Height = 100;
                botonPro.Width = 100;
                botonPro.Click += new EventHandler(clickProducto);
                flpProductos.Controls.Add(botonPro);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flpCentra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
