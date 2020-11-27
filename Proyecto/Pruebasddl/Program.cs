using System;
using System.Collections.Generic;
using System.Net.Http;
using clsNegocios;

namespace Pruebasddl
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMesas cmesas = new clsMesas();
            clsCategorias ccatg = new clsCategorias();
            clsProductos cprod = new clsProductos();
            
            List<clsMesas> mesass = new List<clsMesas>();
            List<clsCategorias> categorias = new List<clsCategorias>();
            List<clsProductos> productos = new List<clsProductos>();
            //mesass = cmesas.buscaMesas();
            //categorias = ccatg.OrdenConCatg();
           //productos = cprod.ProductoEnCatg("1");

            categorias = ccatg.TodosCategorias();
            categorias = ccatg.BuscarCategorias();


            ReportesDeMesaCLS reporteMesa = new ReportesDeMesaCLS();
            List<ReportesDeMesaCLS> listaMesa = new List<ReportesDeMesaCLS>();
            // listaMesa = reporteMesa.ReporteMesas();


            ReportesDeOrdenesCLS reporteOrden = new ReportesDeOrdenesCLS();
            List<ReportesDeOrdenesCLS> listaOrden = new List<ReportesDeOrdenesCLS>();
            //listaOrden = reporteOrden.ReporteOrdenes();

            ReportesDeProductosCLS reporteProductos = new ReportesDeProductosCLS();
            List<ReportesDeProductosCLS> listaProductos = new List<ReportesDeProductosCLS>();
            listaProductos = reporteProductos.ReporteProducto();

            clsUsuario clsUsuario = new clsUsuario();
            List<clsUsuario> listaUsuario = new List<clsUsuario>();
            listaUsuario = clsUsuario.TodosUsuarios();

        }
    }
}
