using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneServicios")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private const decimal V = 200.00m;

        [HttpGet]
        public IActionResult GetServicios()
        {
            var servicios = new List<Servicios>
            {
                new Servicios { Id = 1, Nombre = "Cambio de llantas", Descripcion = "ambio de llantas por defectuosas con garantia ", CostoBase = 600.00m },
                new Servicios { Id = 2, Nombre = "servivio mayor premium", Descripcion = "Servicio completo", CostoBase = 850.00m },
                new() { Id = 3, Nombre = "mantenimiento de motor", Descripcion = "limpiza de motor y todos sus servivios ", CostoBase = V }
            };

            return Ok(servicios);
        }
    }
}
