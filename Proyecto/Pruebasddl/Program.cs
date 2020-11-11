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
            mesass = cmesas.buscaMesas();
            categorias = ccatg.OrdenConCatg();
            productos = cprod.ProductoEnCatg("1");
        }
    }
}
