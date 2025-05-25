using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneVehiculos")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            var vehiculos = new List<Vehiculos>
            {
                new Vehiculos { Id = 1, ClienteId = 1, Marca = "Mazda cvx", Modelo = "mazda", recibo = "123zxf", Observaciones = "servicio incompleto" },
                new Vehiculos { Id = 2, ClienteId = 2, Marca = "Ford range 4x4", Modelo = "ford", recibo = "FDX1652", Observaciones = "cambio de llanteas con granatia" },
                new Vehiculos { Id = 3, ClienteId = 3, Marca = "Chevrolet camaro", Modelo = "chevrolet", recibo = " ABC252", Observaciones = null }
            };

            return Ok(vehiculos);
        }
    }
}

