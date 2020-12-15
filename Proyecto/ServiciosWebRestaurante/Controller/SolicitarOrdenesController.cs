using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using clsNegocios;

namespace ServiciosWebRestaurante.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitarOrdenesController : ControllerBase
    {
        [HttpPost]
        [Route("mesas")]
        public IActionResult solicitarMesas()
        {
            clsMesas mesas = new clsMesas();
            List<clsMesas> todos = new List<clsMesas>();
            todos = mesas.buscaMesas();

            if (todos.Count == 0)
                return NotFound(todos);
            else
                return Ok(todos);
        }
        [HttpPost]
        [Route("puntscl")]
        public IActionResult points([FromBody] clsCliente cod)
        {
            clsCliente cliente = new clsCliente();
            cliente = new clsCliente().comprobarPuntos(cod.id_cliente);
            if (cliente.mensaje == "0")
                return NotFound(cliente);
            else
                return Ok(cliente);
        }

        [HttpPost]
        [Route("nuevaorden")]
        public IActionResult NuevaOrden([FromBody] Model.clsAgregarOrdenModel nuevo)
        {
            List<Model.clsProducOrden> pasto = new List<Model.clsProducOrden>();
            pasto = nuevo.productos;

            try
            {
                clsOrdenEncabezado obj = new clsOrdenEncabezado();
                string i = obj.IdParaNuevaOrden(nuevo.total, nuevo.iduser, nuevo.mesa, nuevo.idclient);
                //ciclo que insertara el arreglo de los productos en la orden
                for (int j = 0; j < pasto.Count; j++)
                {
                    clsOrdenDetalle obj2 = new clsOrdenDetalle();
                    obj2.insertarDetalleOrden(i, pasto[j].idproduct, pasto[j].cantidades, pasto[j].preciosss, pasto[j].totality);
                }
                if (pasto.Count == 0)
                    return NotFound(pasto);
                else
                    return Ok(i);
            }
            catch (Exception e)
            {
                return NotFound(pasto);
            }
        }
        [HttpPost]
        [Route("anular")]
        public IActionResult denegarOrden([FromBody] clsOrdenEncabezado id)
        {
            clsOrdenEncabezado ord = new clsOrdenEncabezado();
            string estadoAnular = ord.cancelarOrden(id.id_orden);
                if (estadoAnular != "ok")
                    return NotFound(estadoAnular);
                else
                    return Ok(estadoAnular);
        }
        [HttpPost]
        [Route("ordenterminar")]
        public IActionResult terminarOrden([FromBody] clsOrdenEncabezado id)
        {
                clsOrdenEncabezado ord = new clsOrdenEncabezado();
                string estadoAnular = ord.endOrden(id.id_orden);
                if (estadoAnular != "ok")
                    return NotFound(estadoAnular);
                else
                    return Ok(estadoAnular);
        }
        [HttpPost]
        [Route("estadococina")]
        public IActionResult cambioEstadoOrdenCocina([FromBody] clsOrdenEncabezado id)
        {
            clsOrdenEncabezado ord = new clsOrdenEncabezado();
            string estadoAnular = ord.cambioestado(id.numero_mesa);
            if (estadoAnular != "ok")
                return NotFound(estadoAnular);
            else
                return Ok(estadoAnular);
        }

        [HttpPost]
        [Route("categorias")]
        public IActionResult solicitarCategorias()
        {
            clsCategorias categ = new clsCategorias();
            List<clsCategorias> todos = new List<clsCategorias>();
            todos = categ.OrdenConCatg();

            if (todos.Count == 0)
                return NotFound(todos);
            else
                return Ok(todos);
        }

        [HttpPost]
        [Route("productoscatg")]
        public IActionResult solicitarProdCatg([FromBody] clsProductos productos)
        {
            clsProductos prod = new clsProductos();
            List<clsProductos> todos = new List<clsProductos>();
            todos = prod.ProductoEnCatg(productos.id_categoria);

            if (todos.Count == 0)
                return NotFound(todos);
            else
                return Ok(todos);
        }

    }
}
