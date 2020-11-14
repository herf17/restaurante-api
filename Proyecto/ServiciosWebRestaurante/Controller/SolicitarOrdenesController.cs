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
    }
}
