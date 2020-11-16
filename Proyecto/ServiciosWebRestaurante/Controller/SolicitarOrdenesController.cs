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
        [Route("nuevaorden")]
        public IActionResult NuevaOrden([FromBody]Model.clsAgregarOrdenModel  nuevo)
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
    }
}
