//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//using clsNegocios;

//namespace ServiciosWeb.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsuariosController : ControllerBase
//    {
//        [HttpPost]
//        [Route("login")]
//        public IActionResult login([FromBody] clsUsuario user)
//        {
//            clsUsuario obj = new clsUsuario();
//            List<clsUsuario> usuarios = new List<clsUsuario>();
//            obj.usuario = user.usuario;
//            obj.contrasena = user.contrasena;
//            usuarios = obj.Login();
//            if (usuarios.Count == 0)
//                return NotFound(usuarios);
//            else
//                return Ok(usuarios);
//        }

//        [HttpPost]
//        [Route("todos")]
//        public IActionResult todos()
//        {
//            clsUsuario obj = new clsUsuario();
//            List<clsUsuario> usuarios = new List<clsUsuario>();
//            usuarios = obj.TodosUsuarios();
//            if (usuarios.Count == 0)
//                return NotFound(usuarios);
//            else
//                return Ok(usuarios);
//        }

//        [HttpPost]
//        [Route("buscar")]
//        public IActionResult buscar([FromBody] clsUsuario user)
//        {
//            clsUsuario obj = new clsUsuario();
//            List<clsUsuario> usuarios = new List<clsUsuario>();
//            obj.id_usuario = user.id_usuario;
//            usuarios = obj.BuscaUsuario();
//            if (usuarios.Count == 0)
//                return NotFound(usuarios);
//            else
//                return Ok(usuarios);
//        }

//        [HttpPost]
//        [Route("insertar")]
//        public IActionResult insertar([FromBody] clsUsuario user)
//        {
//            return Ok(user.insert_ususario());
//        }

//        [HttpPost]
//        [Route("actualizar")]
//        public IActionResult actualizar([FromBody] clsUsuario user)
//        {
//            return Ok(user.update_ususario());
//        }
//    }
//}

