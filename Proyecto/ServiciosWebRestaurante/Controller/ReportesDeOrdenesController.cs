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
    public class ReportesDeOrdenesController : ControllerBase
    {
        [HttpPost]
        [Route("ReporteOrdenes")]
        public IActionResult ReporteOrdenes()
        {
            ReportesDeOrdenesCLS RDO = new ReportesDeOrdenesCLS();
            List<ReportesDeOrdenesCLS> listaOrdenes = new List<ReportesDeOrdenesCLS>();
            listaOrdenes = RDO.ReporteOrdenes();

            if (listaOrdenes.Count == 0)
            {
                return NotFound(listaOrdenes);
            }
            else
            {
                return Ok(listaOrdenes);
            }
        }
    }
        
}
