using GestionTaller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GestionTaller.Controllers
{
    [Route("api/obtieneClientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Angel", Apellido = "Montesuma", Direccion = "Zona 3", Telefono = "3584159", Correo = "Angelmontesuma@gmail.com" },
                new Cliente { Id = 2, Nombre = "cesar", Apellido = "perez", Direccion = "zona 10", Telefono = "618451384", Correo = "cesarperez123@gmail.com" },
                new Cliente { Id = 3, Nombre = "Caterine", Apellido = "juarez", Direccion = "zona 13", Telefono = "15863547", Correo = "Katijuarez@gmail" },
                new Cliente { Id = 4, Nombre = "Ana", Apellido = "lopez", Direccion = "zona 4", Telefono = "12345678", Correo = "Analopez33@gmail.com" },
                new Cliente { Id = 5, Nombre = "Pablo", Apellido = "Gutierrez", Direccion = "zona 5", Telefono = "45879862", Correo = "pabloguti@gmail.com" }
            };

            return Ok(clientes);
        }
    }
}