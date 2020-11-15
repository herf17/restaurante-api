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

        public void NuevaOrden()
        {
            try
            {
                clsOrdenEncabezado obj = new clsOrdenEncabezado();
                string i = obj.IdParaNuevaOrden("50.99", "3", "2", "3");
                //ciclo que insertara el arreglo de los productos en la orden
                for (int j = 1; j < 4; j++)
                {
                    clsOrdenDetalle obj2 = new clsOrdenDetalle();
                    obj2.insertarDetalleOrden(i, j.ToString(), j.ToString(), j.ToString(), "24.99");
                }


            }
            catch (Exception e)
            {

            }


        }
    }
}
