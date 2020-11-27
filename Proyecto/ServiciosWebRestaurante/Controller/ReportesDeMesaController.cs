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
    public class ReportesDeMesaController : ControllerBase
    {

        [HttpPost]
        [Route ("ReporteMesa")]
        public IActionResult ReporteMesa()
        {
            ReportesDeMesaCLS RDM = new ReportesDeMesaCLS();
            List<ReportesDeMesaCLS> listaMesa = new List<ReportesDeMesaCLS>();
            listaMesa = RDM.ReporteMesas();

            if (listaMesa.Count == 0)
            {
                return NotFound(listaMesa);
            }
            else
            {
                return Ok(listaMesa);
            }
        }



    }
}
