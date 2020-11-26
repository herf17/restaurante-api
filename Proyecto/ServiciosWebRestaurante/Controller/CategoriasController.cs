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
    public class CategoriasController : ControllerBase
    {
        public CategoriasController() { }


        /// <summary>
         /// metodo que busca a las todas las categorias 
         /// </summary>
         /// <returns>categorias</returns>
        [HttpPost]
        [Route("todos")]
        public IActionResult todos()
        {
            clsCategorias clscategorias = new clsCategorias();
            List<clsCategorias> categorias = new List<clsCategorias>();
            categorias = clscategorias.TodosCategorias();
            if (categorias.Count == 0)
                return NotFound(categorias);
            else
                return Ok(categorias);
        }

        /// <summary>
        /// metodo que busca a las categorias una por una 
        /// </summary>
        /// <param name="clsCategorias"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("buscar")]
        public IActionResult buscar([FromBody] clsCategorias clsCategorias)
        {
            clsCategorias clscategorias = new clsCategorias();
            List<clsCategorias> categorias = new List<clsCategorias>();
            clsCategorias.id_categoria = clsCategorias.id_categoria;
            categorias = clscategorias.BuscarCategorias();
            if (categorias.Count == 0)
                return NotFound(categorias);
            else
                return Ok(categorias);
        }

        /// <summary>
        /// metodo que ingresa una categoria 
        /// </summary>
        /// <param name="clsCategorias"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("insertar")]
        public IActionResult insertar([FromBody] clsCategorias clsCategorias)
        {
            return Ok(clsCategorias.insertCategoria());
        }

        /// <summary>
        /// metodo que actualiza a un categoria
        /// </summary>
        /// <param name="clsCategorias"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("actualizar")]
        public IActionResult actualizar([FromBody] clsCategorias clsCategorias)
        {
            return Ok(clsCategorias.updateCategoria());
        }

    }
}
