using InyeccionDeDependencias.EjemploSinDY;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InyeccionDeDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploSinDYController : ControllerBase
    {
        [HttpGet]
        public bool EnviarMail([FromQuery] string mail)
        {
            UsuarioServiceSinDY usuarioServiceSinDY = new UsuarioServiceSinDY();
           return usuarioServiceSinDY.EnviarNotificacionUsuario(mail); 

            //Controller new UsuarioServiceSinDY --> new EmailServiceSinDY --> Enviar...
        }

    }
}
