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
    public class ClienteController : ControllerBase
    {
        public ClienteController() { }

        /// <summary>
        /// metodo que busca a los todos clientes 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("todos")]
        public IActionResult todos()
        {
            clsCliente clscliente = new clsCliente();
            List<clsCliente> clientes = new List<clsCliente>();
            clientes = clscliente.TodosClientes();
            if (clientes.Count == 0)
                return NotFound(clientes);
            else
                return Ok(clientes);
        }

        /// <summary>
        /// metodo que busca a los clientes una por una 
        /// </summary>
        /// <param name="clsCliente"></param>
        /// <returns></returns>
        
        [HttpPost]
        [Route("buscar")]
        public IActionResult buscar([FromBody] clsCliente clsCliente)
        {
            clsCliente clscliente = new clsCliente();
            List<clsCliente> clientes = new List<clsCliente>();
            clscliente.id_cliente = clsCliente.id_cliente;
            clientes = clscliente.BuscarCliente();
            if (clientes.Count == 0)
                return NotFound(clientes);
            else
                return Ok(clientes);
        }

        /// <summary>
        /// metodo que ingresa a un cliente 
        /// </summary>
        /// <param name="clsCliente"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("insertar")]
        public IActionResult insertar([FromBody] clsCliente clsCliente)
        {
            return Ok(clsCliente.insertCliente());
        }

        /// <summary>
        /// metodo que actualiza a un cliente
        /// </summary>
        /// <param name="clsCliente"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("actualizar")]
        public IActionResult actualizar([FromBody] clsCliente clsCliente)
        {
            return Ok(clsCliente.updateCliente());
        }

    }
}
