using CalculadoraDivPrimoAPI.Model;
using CalculadoraDivPrimoAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalculadoraDivPrimoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraDivPrimoController : ControllerBase
    {
        [HttpGet("GetNumeroDivPrimo/{valor}")]
        public IActionResult GetNumeroDivPrimo(string valor)
        {
            try
            {
                CalculadoraService apiCalculadora = new CalculadoraService();

                ModelCalculadora listaDivPrimos = apiCalculadora.CalculadoraAPIService(valor);

                var json = JsonSerializer.Serialize(listaDivPrimos, new JsonSerializerOptions { WriteIndented = true });
                
                return Ok(json);
            }
            catch (Exception ex)
            {
                return BadRequest("Não é um Numero");
            }
        }

        [HttpGet]
        public string Get()
        {
            return "Para fazer funciona tem que colocar o endpoint igual api/CalculadoraDivPrimo/GetNumeroDivPrimo/{valor} na URL";
        }
    }
}
