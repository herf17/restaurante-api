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
            /*clsMesas cmesas = new clsMesas();
            clsCategorias ccatg = new clsCategorias();
            clsProductos cprod = new clsProductos();
            List<clsMesas> mesass = new List<clsMesas>();
            List<clsCategorias> categorias = new List<clsCategorias>();
            List<clsProductos> productos = new List<clsProductos>();
            mesass = cmesas.buscaMesas();
            categorias = ccatg.OrdenConCatg();
            productos = cprod.ProductoEnCatg("1");*/
            //clsOrdenEncabezado obj = new clsOrdenEncabezado();
            //string i = obj.IdParaNuevaOrden("68.99", "3", "2", "3");
            //prueba de los servivios sin usar el controlador
            try
            {
                clsOrdenEncabezado obj = new clsOrdenEncabezado();
                
                string i = obj.IdParaNuevaOrden("50.99", "3", "2", "3");
                for (int j = 1; j < 4; j++)
                {
                    clsOrdenDetalle obj2 = new clsOrdenDetalle();
                    obj2.insertarDetalleOrden(i, j.ToString(), j.ToString(), j.ToString(), "25.99");
                }
                    

            }
            catch (Exception e)
            {

            }
        }
    }
}
