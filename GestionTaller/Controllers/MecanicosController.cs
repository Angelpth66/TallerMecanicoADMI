using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneMecanicos")]
    [ApiController]
    public class MecanicosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMecanicos()
        {
            var mecanicos = new List<Mecanicos>
            {
                new Mecanicos { Id = 1, Nombre = "Juan", Apellido = "Hernandez", TallerId = 1 },
                new Mecanicos { Id = 2, Nombre = "matias", Apellido = "Paredes", TallerId = 2 },
                new Mecanicos { Id = 3, Nombre = "Alexis", Apellido = "fuentes", TallerId = null }
            };

            return Ok(mecanicos);
        }
    }
}
