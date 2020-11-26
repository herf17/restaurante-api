using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using clsNegocios;

namespace ServiciosWebRestaurante.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public ProductosController() { }


        /// <summary>
        /// metodo que busca a los todos Productos 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("todos")]
        public IActionResult todos()
        {
            clsProductos clsproductos = new clsProductos();
            List<clsProductos> productos = new List<clsProductos>();
            productos = clsproductos.TodosProductos();
            if (productos.Count == 0)
                return NotFound(productos);
            else
                return Ok(productos);
        }

        /// <summary>
        /// metodo que busca a los Productos una por una 
        /// </summary>
        /// <param name="clsProductos"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("buscar")]
        public IActionResult buscar([FromBody] clsProductos clsProductos)
        {
            clsProductos clsproductos = new clsProductos();
            List<clsProductos> productos = new List<clsProductos>();
            clsproductos.id_producto = clsProductos.id_producto;
            productos = clsproductos.BuscarProductos();
            if (productos.Count == 0)
                return NotFound(productos);
            else
                return Ok(productos);
        }

        /// <summary>
        /// metodo que ingresa un producto 
        /// </summary>
        /// <param name="clsProductos"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("insertar")]
        public IActionResult insertar([FromBody] clsProductos clsProductos)
        {
            return Ok(clsProductos.insertProductos());
        }

        /// <summary>
        /// metodo que actualiza a un cliente
        /// </summary>
        /// <param name="clsProductos"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("actualizar")]
        public IActionResult actualizar([FromBody] clsProductos clsProductos)
        {
            return Ok(clsProductos.updateProductos());
        }


    }
}
