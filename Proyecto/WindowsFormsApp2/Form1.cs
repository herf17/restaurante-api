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
        public delegate void OrdenNueva(string str);
        public event OrdenNueva OnAviso;


        private String urlcatgcont = "solicitarordenes/categorias";
        private String urlprodgcont = "solicitarordenes/productoscatg";
        private String urlclpnts = "solicitarordenes/puntscl";
        private String urlnuevaorden = "solicitarordenes/nuevaorden";
        private String coman = null;
        string idcliente;
        string idmesa;
        int idmenu;
        List<Model.CategModel> listaCatg;
        List<Model.ProdEnCatgModel> prodCatg;
        Model.SolcClsModel clienteinfo;
        
        public Form1(string idmesa)
        {
            InitializeComponent();
            this.idmesa = idmesa;
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
            Button button = sender as Button;
            idmenu =int.Parse(button.Name.Substring(button.Name.Length - 1));
            escojerCantidadProducto ecp = new escojerCantidadProducto();
            ecp.OnMessage += new escojerCantidadProducto.Message(this.txtMessage);
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

        private void txtMessage(string str)
        {
            dataGridView1.Rows.Add(prodCatg[idmenu].id_producto,prodCatg[idmenu].descripcion,str,prodCatg[idmenu].precio);
            refreshtotal();
        }

        private void edit(string nuevo)
        {
            int indicef = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[indicef].Cells[2].Value = nuevo;
            refreshtotal();
        }

        private void refreshtotal()
        {
            
            double acumulador = 0.00;
            foreach(DataGridViewRow fila in dataGridView1.Rows)
            {
                string g =fila.Cells["canti"].Value.ToString();
                double a = double.Parse(fila.Cells["canti"].Value.ToString());
                double b = double.Parse(fila.Cells["preci"].Value.ToString());
                acumulador +=(a*b);
            }
            txbtotal.Text = acumulador.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flpCentra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                escojerCantidadProducto ecp = new escojerCantidadProducto();
                ecp.OnMessage += new escojerCantidadProducto.Message(this.edit);
                ecp.ShowDialog();
                
            }
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                int indicef = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(indicef);
                refreshtotal();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btcli_Click(object sender, EventArgs e)
        {
            idcliente = txtidcli.Text;
            ApiBase llamada = new ApiBase();
            Model.SolcClsModel modelo = new Model.SolcClsModel();
            modelo.id_cliente = idcliente;
            IRestResponse resp = llamada.execApi(urlclpnts, JsonConvert.SerializeObject(modelo));
            clienteinfo = JsonConvert.DeserializeObject<Model.SolcClsModel>(resp.Content);
            lbnombre.Text = String.Concat(clienteinfo.nombre, clienteinfo.apellido);
            lbpunts.Text = clienteinfo.puntos;

        }

        private void btcompra_Click(object sender, EventArgs e)
        {
            ApiBase apbasep = new ApiBase();
            Model.NuevaOrdenModel obj = new Model.NuevaOrdenModel();
            obj.total = txbtotal.Text;
            obj.iduser = "2";//aqui va el id del usuario que se obtiene con el login
            obj.mesa =idmesa;
            obj.idclient = idcliente;
            List<Model.ProductosEnOrdenModel> productoss = new List<Model.ProductosEnOrdenModel>();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                double c =double.Parse(fila.Cells["canti"].Value.ToString());
                double p = double.Parse(fila.Cells["preci"].Value.ToString());
                double t = (c * p);
                productoss.Add(new Model.ProductosEnOrdenModel {idproduct =fila.Cells["idproducto"].Value.ToString(),cantidades= c.ToString(),preciosss= p.ToString(),totality=t.ToString()});
            }
            obj.productos = productoss;
            IRestResponse respues = apbasep.execApi(urlnuevaorden, JsonConvert.SerializeObject(obj));
            string h = JsonConvert.DeserializeObject<String>(respues.Content);
            if (!string.IsNullOrEmpty(h))
            {
                this.OnAviso(h);
                this.Close();

            }
            else
                MessageBox.Show("Error");
        }
    }
}
