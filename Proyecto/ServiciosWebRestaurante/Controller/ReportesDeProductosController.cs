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
    public class ReportesDeProductosController : ControllerBase
    {
        [HttpPost]
        [Route("ReporteProductos")]
        public IActionResult ReporteProductos()
        {
            ReportesDeProductosCLS RDP = new ReportesDeProductosCLS();
            List<ReportesDeProductosCLS> listaProductos = new List<ReportesDeProductosCLS>();
            listaProductos = RDP.ReporteProducto();

            if (listaProductos.Count == 0)
            {
                return NotFound(listaProductos);
            }
            else
            {
                return Ok(listaProductos);
            }
        }
    }
}
